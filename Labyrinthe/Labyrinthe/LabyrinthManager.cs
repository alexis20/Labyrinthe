using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Labyrinth
{
	public class LabyrinthGenerator
	{
		#region Variables

		private const int TILESIZE = 15;

		private static Random rnd = new Random();

		private bool hasBeenDisplayed = false;	
		private int _longestPathSoFar;
		private int _width, _height;
		private Point _currentTile;
		private List<char[]> _indexes;

		/// <summary>
		/// The stack of points no tested yet
		/// </summary>
		private Stack<Point> _tileToTry = new Stack<Point>();

		/// <summary>
		/// The list of offsets to use to get the tiles above, below, to the right and the left of a specific tile
		/// </summary>
		private List<Point> _offsets = new List<Point> { new Point(0, 1), new Point(0, -1), new Point(1, 0), new Point(-1, 0) };

		#endregion

		#region Properties

		public byte[,] Labyrinth { get; private set; }

		public Point FurthestPoint { get; private set; }

		public int Width
		{
			get { return _width; }
			private set { _width = value; }
		}

		public int Height
		{
			get { return _height; }
			private set { _height = value; }
		}

		public Point CurrentTile
		{
			get { return _currentTile; }
			private set { if (value.X % 2 == 1 || value.Y % 2 == 1) _currentTile = value; }
		}

		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new LabyrinthGenerator with mazes starting at (1,1).
		/// </summary>
		/// <param name="pWidth">The number of tiles across in the mazes to generate. Must include the two extra tiles for a wall in both sides.</param>
		/// <param name="pHeight">The number of tiles from top to bottom in the mazes to generate. Must include the two ekstra tiles for a wall both at top and bottom.</param>
		public LabyrinthGenerator(int pWidth, int pHeight) : this(pWidth, pHeight, new Point(1, 1)) { }


		/// <summary>
		/// Creates a new LabyrinthGenerator with mazes starting at the requested startingPosition.
		/// </summary>
		/// <param name="pWidth">The number of tiles across in the mazes to generate. Must include the two ekstra tiles for a wall in both sides.</param>
		/// <param name="pHeight">The number of tiles from top to bottom in the mazes to generate. Must include the two ekstra tiles for a wall both at top and bottom.</param>
		/// <param name="pStartingPosition">The player's starting position.</param>
		public LabyrinthGenerator(int pWidth, int pHeight, Point pStartingPosition)
		{
			Width = pWidth;
			Height = pHeight;
			hasBeenDisplayed = false;

			_indexes = new List<char[]>();
			Labyrinth = new byte[Width, Height];

			// Initialize all fields as taken
			for (int x = 0; x < Width; ++x)
			{
				for (int y = 0; y < Height; ++y)
					Labyrinth[x, y] = 1;
			}

			// Start the excavation from the current position
			CurrentTile = pStartingPosition;

			// Add the beginning position to the tiles to try
			_tileToTry.Push(CurrentTile);

			// Generate a new labyrinth
			Generate();
		}

		#endregion

		#region Methods

		/// <summary>
		/// Return the labyrinth into a bitmap format
		/// </summary>
		/// <returns>The labyrinth in a bitmap format</returns>
		public Bitmap DisplayLabyrinth()
		{
			// Create a new bitmap with a pixel extra for each tile +1 for drawing a grid around all tiles
			Bitmap bmp = new Bitmap(1 + (TILESIZE + 1) * Width, 1 + (TILESIZE + 1) * Height);
			Graphics g = Graphics.FromImage(bmp);

			// Fill the grapics with grey
			g.FillRectangle(Brushes.DarkGray, new Rectangle(0, 0, bmp.Width, bmp.Height));

			// Get the current maze as a string, and replace any newlines
			string mazeString = ToString().Replace(Environment.NewLine, "");

			// Store a fillBrush as white
			Brush fillBrush = Brushes.White;

			// For each tile, get a brush that is the correct color
			for (int y = 0; y < Height; ++y)
			{
				for (int x = 0; x < Width; ++x)
				{
					switch (mazeString[x + y * Width])
					{
						case 'X':	// Wall
							fillBrush = Brushes.Black;
							break;
						case 'O':	// Player
							fillBrush = Brushes.Red;
							break;
						case ' ':	// Path
							fillBrush = Brushes.White;
							break;
						case '*':	// Exit
							fillBrush = Brushes.LightGreen;
							break;
						case '_':	// Torch bonus
							fillBrush = Brushes.Gold;
							break;
						case '.':	// More steps bonus
							fillBrush = Brushes.CornflowerBlue;
							break;
					}
					// Draw the tile in
					g.FillRectangle(fillBrush, 1 + x * (TILESIZE + 1), 1 + y * (TILESIZE + 1), TILESIZE, TILESIZE);
				}
			}
			// Dispose of the graphics object
			g.Dispose();

			return bmp;
		}


		/// <summary>
		/// Returns a textmap of the maze.
		/// </summary>
		/// <returns>A textual representation of the maze</returns>
		public override string ToString()
		{
			string representation = string.Empty;
			StringBuilder sb = new StringBuilder();

			for (int y = Height - 1; y >= 0; --y)
			{
				for (int x = 0; x < Width; ++x)
				{
					if (Labyrinth[x, y] == 0)
					{
						// If it's the current tile, represent it with an "O"
						if (CurrentTile.X == x && CurrentTile.Y == y)
							representation = "O";
						else
						{
							// If it's still one to test
							if (!_tileToTry.Contains(new Point(x, y)))
								representation = " "; // Already been there
							if (FurthestPoint.X == x && FurthestPoint.Y == y)
								representation = "*";
						}
					}
					else
						representation = "X";  // It is unexcavated (wall)

					sb.Append(representation);
				}

				if (!hasBeenDisplayed)
				{
					SetBonuses(sb, '_');
					SetBonuses(sb, '.');
				}

				sb.AppendLine();
			}

			if (hasBeenDisplayed)
			{
				for (int i = _indexes.Count - 1; i >= 0; --i)
				{
					char[] index = _indexes[i];
					if (sb[index[0]].Equals(' '))
						sb[index[0]] = index[1];
					if (sb[index[0]].Equals('O'))	// I've gone through the bonus, it needs to disappear
					{
						char[] newTab = new char[2];
						newTab[0] = index[0];
						newTab[1] = ' ';
						_indexes[_indexes.IndexOf(index)] = newTab;
					}
				}
			}

			if (!hasBeenDisplayed) hasBeenDisplayed = true;
			return sb.ToString();
		}


		/// <summary>
		/// Update the player's position
		/// </summary>
		/// <param name="pNewPosition">The new position of the player</param>
		public void MovePlayer(Point pNewPosition)
		{
			if (IsInside(pNewPosition) && IsOnPath(pNewPosition))
				CurrentTile = pNewPosition;
		}


		private void SetBonuses(StringBuilder sb, char c)
		{
			int index = rnd.Next(sb.Length);
			char[] tab = new char[2];
			if (sb[index].Equals(' '))
				sb[index] = c;
			tab[0] = (char)index;
			tab[1] = c;
			_indexes.Add(tab);
		}


		/// <summary>
		/// Creates a new maze with the current size and starting position
		/// </summary>
		/// <returns>A freshly generated, random maze</returns>
		private byte[,] Generate()
		{
			// Local variable to store neighbors to the current square
			// As we work our way through the maze
			List<Point> neighbors;

			// As long as there are still tiles to try
			while (_tileToTry.Count > 0)
			{
				// Excavate the square we are on
				Labyrinth[CurrentTile.X, CurrentTile.Y] = 0;

				// Get all valid neighbors for the new tile  
				neighbors = GetValidNeighbors(CurrentTile);

				// If there are any interesting looking neighbors
				if (neighbors.Count > 0)
				{
					// Remember this tile, by putting it on the stack
					_tileToTry.Push(CurrentTile);

					// Move on to a random of the neighboring tiles
					CurrentTile = neighbors[rnd.Next(neighbors.Count)];
				}
				else
				{
					// If there were no neighbors to try, we are at a dead-end
					// Test to see if this dead end will be the furthest point in the maze
					UpdateFurthestPoint();

					// Toss this tile out 
					CurrentTile = _tileToTry.Pop();
				}
			}

			return Labyrinth;
		}


		/// <summary>
		/// Update the furthest point
		/// </summary>
		private void UpdateFurthestPoint()
		{
			if (_tileToTry.Count > _longestPathSoFar)
			{
				_longestPathSoFar = _tileToTry.Count;
				FurthestPoint = CurrentTile;
			}
		}


		/// <summary>
		/// Get all the prospective neighboring tiles
		/// </summary>
		/// <param name="pCenterTile">The tile to test</param>
		/// <returns>All and any valid neighbors</returns>
		private List<Point> GetValidNeighbors(Point pCenterTile)
		{
			List<Point> validNeighbors = new List<Point>();

			// Check all four directions around the tile
			foreach (var offset in _offsets)
			{
				// Find the neighbor's position
				Point toCheck = new Point(pCenterTile.X + offset.X, pCenterTile.Y + offset.Y);

				// Make sure the tile is not on both an even X-axis and an even Y-axis
				// to ensure we can get walls around all tunnels
				if (toCheck.X % 2 == 1 || toCheck.Y % 2 == 1)
				{
					// If the potential neighbor is unexcavated (==1)
					// and still has three walls intact (new territory)
					if (Labyrinth[toCheck.X, toCheck.Y] == 1 && HasThreeWallsIntact(toCheck))
					{
						// Add the neighbor
						validNeighbors.Add(toCheck);
					}
				}
			}

			return validNeighbors;
		}


		/// <summary>
		/// Counts the number of intact walls around a tile
		/// </summary>
		/// <param name="pPointToCheck">The coordinates of the tile to check</param>
		/// <returns>Whether there are three intact walls (the tile has not been dug into earlier.</returns>
		private bool HasThreeWallsIntact(Point pPointToCheck)
		{
			int intactWallCounter = 0;

			// Check all four directions around the tile
			foreach (var offset in _offsets)
			{
				// Find the neighbor's position
				Point neighborToCheck = new Point(pPointToCheck.X + offset.X, pPointToCheck.Y + offset.Y);

				// Make sure it is inside the maze, and it hasn't been dug out yet
				if (IsInside(neighborToCheck) && Labyrinth[neighborToCheck.X, neighborToCheck.Y] == 1)
					intactWallCounter++;
			}

			// Tell whether three walls are intact
			return intactWallCounter == 3;
		}


		/// <summary>
		/// Find out whether a tile is inside the maze
		/// </summary>
		/// <param name="pPoint">The coordinates of the tile to check</param>
		/// <returns>Whether the tile is inside the maze</returns>
		private bool IsInside(Point pPoint)
		{
			return pPoint.X >= 0 && pPoint.Y >= 0 && pPoint.X < Width && pPoint.Y < Height;
		}


		/// <summary>
		/// Find out if the position of the player is still on the path
		/// </summary>
		/// <param name="pPoint">The coordinates of the tile to check</param>
		/// <returns>Whether the player is still on path</returns>
		private bool IsOnPath(Point pPoint)
		{
			return Labyrinth[pPoint.X, pPoint.Y] == 0;
		}

		#endregion
	}
}