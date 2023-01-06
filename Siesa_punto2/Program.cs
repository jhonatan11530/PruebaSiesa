using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siesa_punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(1, 4);
            tree.Add(2, 7);
            tree.Add(3, 20);

            tree.CalculateAverageWeights();
            tree.CalculateHeights();

            tree.PrintTable();


            Console.ReadLine();
        }
        /// <summary>
        /// Clase que representa un árbol con peso.
        /// </summary>
        public class Tree
        {
            /// <summary>
            /// Nodo raíz del árbol.
            /// </summary>
            private class TreeNode
            {
                public int Value { get; set; }
                public int Weight { get; set; }
                public int AverageWeight { get; set; }
                public int Height { get; set; }
                public TreeNode Left { get; set; }
                public TreeNode Right { get; set; }

                public TreeNode(int value, int weight)
                {
                    Value = value;
                    Weight = weight;
                }
            }

            private TreeNode root;

            /// <summary>
            /// Agrega un nodo al árbol.
            /// </summary>
            /// <param name="value">Valor del nodo a agregar.</param>
            /// <param name="weight">Peso del nodo a agregar.</param>
            public void Add(int value, int weight)
            {
                if (root == null)
                {
                    root = new TreeNode(value, weight);
                    return;
                }

                TreeNode current = root;
                while (true)
                {
                    if (value < current.Value)
                    {
                        if (current.Left == null)
                        {
                            current.Left = new TreeNode(value, weight);
                            break;
                        }
                        current = current.Left;
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            current.Right = new TreeNode(value, weight);
                            break;
                        }
                        current = current.Right;
                    }
                }
            }

            public int CalculateHeights()
            {
                return CalculateHeights(root);
            }

            /// <summary>
            /// Calcula la altura de cada nodo del árbol.
            /// </summary>
            /// <param name="node">Nodo a partir del cual se calculará la altura.</param>
            private int CalculateHeights(TreeNode node)
            {
                if (node == null)
                {
                    return 0;
                }

                int leftHeight = CalculateHeights(node.Left);
                int rightHeight = CalculateHeights(node.Right);

                node.Height = Math.Max(leftHeight, rightHeight) + 1;

                return node.Height;
            }

            public void CalculateAverageWeights()
            {
                CalculateAverageWeights(root);
            }

            /// <summary>
            /// Calcula el peso promedio de cada nodo del árbol.
            /// </summary>
            /// <param name="node">Nodo a partir del cual se calculará el peso promedio.</param>
            private void CalculateAverageWeights(TreeNode node)
            {
                if (node == null)
                {
                    return;
                }

                int leftWeight = CalculateTotalWeight(node.Left);
                int rightWeight = CalculateTotalWeight(node.Right);

                int totalWeight = leftWeight + rightWeight + node.Weight;
                int totalNodes = CountNodes(node.Left) + CountNodes(node.Right) + 1;

                node.AverageWeight = totalWeight / totalNodes;

                CalculateAverageWeights(node.Left);
                CalculateAverageWeights(node.Right);
            }

            /// <summary>
            /// Calcula el peso total del árbol.
            /// </summary>
            /// <returns>Peso total del árbol.</returns>
            private int CalculateTotalWeight(TreeNode node)
            {
                if (node == null)
                {
                    return 0;
                }

                return CalculateTotalWeight(node.Left) + CalculateTotalWeight(node.Right) + node.Weight;
            }

            /// <summary>
            /// Cuenta la cantidad de nodos descendientes del nodo especificado.
            /// </summary>
            /// <param name="node">Nodo a partir del cual se cuentan los nodos descendientes.</param>
            /// <returns>Cantidad de nodos descendientes del nodo especificado.</returns>
            private int CountNodes(TreeNode node)
            {
                if (node == null)
                {
                    return 0;
                }

                return CountNodes(node.Left) + CountNodes(node.Right) + 1;
            }


            public void PrintTable()
            {
                Console.WriteLine("Value | Weight | Average Weight | Height");
                Console.WriteLine("------|--------|----------------|-------");
                PrintTable(root);
            }

            /// <summary>
            /// Imprime el árbol en forma de tabla.
            /// </summary>
            /// <param name="node">Nodo a partir del cual se imprime la tabla.</param>
            private void PrintTable(TreeNode node)
            {
                if (node == null)
                {
                    return;
                }

                Console.WriteLine($"{node.Value,6} | {node.Weight,6} | {node.AverageWeight,14:F5} | {node.Height,7}");

                PrintTable(node.Left);
                PrintTable(node.Right);
            }



        }


    }
}
