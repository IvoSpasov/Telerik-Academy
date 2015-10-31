using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Slides
{
    class Slides
    {
        static void Main(string[] args)
        {         
            string[] dimentions = Console.ReadLine().Split();
            int width = int.Parse(dimentions[0]);
            int height = int.Parse(dimentions[1]);
            int depth = int.Parse(dimentions[2]);
            string[, ,] cube = new string[width, height, depth];

            for (int h = 0; h < height; h++)
            {
                string[] lineFragments = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                for (int d = 0; d < depth; d++)
                {
                    string[] cubeContent = lineFragments[d].Split(new string[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }
                }
            }

            string[] startingPoints = Console.ReadLine().Split();

            int currentWidth = int.Parse(startingPoints[0]);
            int currentHeight = 0;
            int currentDepth = int.Parse(startingPoints[1]);
            bool gameNotOver = true;

            while (gameNotOver)
            {
                string readComand = cube[currentWidth, currentHeight, currentDepth];
                int wCopy = currentWidth;
                int hCopy = currentHeight;
                int dCopy = currentDepth;

                switch (readComand)
                {
                    case "S L": currentWidth--; currentHeight++; break;
                    case "S R": currentWidth++; currentHeight++; break;
                    case "S F": currentDepth--; currentHeight++; break;
                    case "S B": currentDepth++; currentHeight++; break;
                    case "S FL": currentDepth--; currentWidth--; currentHeight++; break;
                    case "S FR": currentDepth--; currentWidth++; currentHeight++; break;
                    case "S BL": currentDepth++; currentWidth--; currentHeight++; break;
                    case "S BR": currentDepth++; currentWidth++; currentHeight++; break;
                    case "E": currentHeight++; break;
                    case "B": 
                        gameNotOver = false;
                        Console.WriteLine("No");
                        Console.WriteLine("{0} {1} {2}", wCopy, hCopy, dCopy);
                        break;
                    default:
                        string[] teleport = readComand.Split();
                        currentWidth = int.Parse(teleport[1]);
                        currentDepth = int.Parse(teleport[2]);
                        break;
                }

                if (currentHeight == height)
                {
                    gameNotOver = false;
                    Console.WriteLine("Yes");
                    Console.WriteLine("{0} {1} {2}", wCopy, hCopy, dCopy);
                }
                else if ((currentHeight < 0 || height < currentHeight) || (currentWidth < 0 || width <= currentWidth ) || (currentDepth < 0 || depth <= currentDepth))
                {
                    gameNotOver = false;
                    Console.WriteLine("No");
                    Console.WriteLine("{0} {1} {2}", wCopy, hCopy, dCopy);
                }
            }
        }
    }
}
