using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario_de_busqueda
{
    public class Binarytree
    {
        //node atributte
        public Node Root;

        //this method will not return anything, it calls recursive func
        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        
        private Node InsertRecursive(Node root, int value)
        { // root is first input value
            if (root == null)
            {
                root = new Node(value);
                return root; //then return given value as root
            }
            // will evaluate the value parameter and if its bigger than root value 
            //make it go left if its smaller make it go right.
            if (value < root.Value)
            {
                root.Left = InsertRecursive(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertRecursive(root.Right, value);
            }
            return root;

        }

        //Graphics will allow drawing
        public void DrawTree(Graphics graphics, Node node, int x, int y, int distanceX, int distanceY)
        {
            if (node == null)
            {
                return;//will not draw if I have no value
            }
             Pen pen = new Pen(Color.Black);
             Brush brush = new SolidBrush(Color.LightBlue);
             Brush fontBrush = new SolidBrush(Color.White);
             Font font = new Font("Arial", 10);//tells computer font node value

            int radio = 20;// DO NOT TOUCH THIS WILL MESS UP COORDINATE CALCULATION

            //Draw node 
            /*graphics.FillEllipse(brush, x - radio, y - radio,2 * radio,2 * radio);
            graphics.DrawEllipse(pen, x - radio, y - radio,2 * radio,2 * radio);
            graphics.DrawString(node.Value.ToString(), font,fontBrush,x-10,y-10);//will draw number

          */

            graphics.FillEllipse(brush, x - radio, y - radio, 2 * radio, 2 * radio);
            graphics.DrawEllipse(pen, x - radio, y - radio, 2 * radio, 2 * radio);
            graphics.DrawString(node.Value.ToString(), font, fontBrush, x - 10, y - 10);

            //Node coonections Draw
            if (node.Left != null)
            {
                /* graphics.DrawLine(pen,x,y,x-distanceX,y-distanceY);
                 DrawTree(graphics,node.Left, x-distanceX,y+distanceY,distanceX/2,distanceY);*/
                graphics.DrawLine(pen, x, y, x - distanceX, y + distanceY);
                DrawTree(graphics, node.Left, x - distanceX, y + distanceY, distanceX / 2, distanceY);

            }
            if (node.Right != null)
            {
                /*graphics.DrawLine(pen,x,y,x+distanceX,y+distanceY);
                DrawTree(graphics, node.Right, x-distanceX, y+distanceY,distanceX/2, distanceY);*/
                graphics.DrawLine(pen, x, y, x + distanceX, y + distanceY);
                DrawTree(graphics, node.Right, x + distanceX, y + distanceY, distanceX / 2, distanceY);
            }
        }
        //will return list of int
        public List<int> GetPreorder(Node node)
        {
            List<int> result = new List<int>();
            PreOrder(node, result);
            return result;
        }

        public void PreOrder(Node node,List<int> result)
        {
            if (node != null)
            {
                result.Add(node.Value);
                PreOrder(node.Left, result);
                PreOrder(node.Right, result);
            } ; 
            
        }
        //where, what are you drawing , place, distance between nodes
        public void DrawPreorder(Graphics graphics, List<int> preorder,int x,int y, int distanceX)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.LightBlue);
            Brush fontBrush = new SolidBrush(Color.White);
            Font font = new Font("Arial", 10);//tells computer font for node value

            int radio = 25;

            for (int i = 0; i < preorder.Count; i++) 
            {
                int value = preorder[i];
                int posX = x + i *distanceX;

                //draw node
                graphics.FillEllipse(brush, posX - radio, y - radio, 2 * radio, 2 * radio);
                graphics.DrawEllipse(pen,posX - radio, y - radio,2*radio,2*radio);
                graphics.DrawString(value.ToString(), font, fontBrush, posX - 10, y - 10);
            }
        }

        public List<int> GetInOrder(Node node)
        {
            List<int> result = new List<int>();
            InOrder(node, result);
            return result;
        }

        private void InOrder(Node node, List<int> result)
        {
            if (node != null)
            {
                InOrder(node.Left, result);
                result.Add(node.Value);
                InOrder(node.Right, result);   

            }
        }

        public void DrawInorder(Graphics graphics, List<int> inorder, int x, int y, int distanceX)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.LightBlue);
            Brush fontBrush = new SolidBrush(Color.White);
            Font font = new Font("Arial", 10);

            int radio = 20;// DO NOT TOUCH THIS WILL MESS UP COORDINATE CALCULATION

            for (int i = 0; i < inorder.Count; i++)
            {
                int value = inorder[i];
                int posX = x + i * distanceX;

                //node Draw
                graphics.FillEllipse(brush, posX - radio, y - radio, 2 * radio, 2 * radio);
                graphics.DrawEllipse(pen, posX - radio, y - radio, 2 * radio, 2 * radio);
                graphics.DrawString(value.ToString(), font, fontBrush, posX - 10, y - 10);

            }
        }

        public List<int> GetPostorder(Node node)
        {
            List<int> result = new List<int>();
            Postorder(node,result);
            return result;
        }

        private void Postorder(Node node, List<int> result)
        {
            if (node != null)
            {
                Postorder(node.Left, result);
                Postorder(node.Right, result);
                result.Add(node.Value);
            }
        }

        public void DrawPostorder(Graphics graphics, List<int> postorder, int x, int y, int distanceX)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.LightBlue);
            Brush fontBrush = new SolidBrush(Color.White);
            Font font = new Font("Arial", 10);

            int radio = 20;// DO NOT TOUCH THIS WILL MESS UP COORDINATE CALCULATION

            for (int i = 0; i < postorder.Count; i++)
            {
                int value = postorder[i];
                int posX = x + i * distanceX;

                //Draw node 
                graphics.FillEllipse(brush, posX - radio, y - radio, 2 * radio, 2 * radio);
                graphics.DrawEllipse(pen, posX - radio, y - radio, 2 * radio, 2 * radio);
                graphics.DrawString(value.ToString(), font, fontBrush, posX - 10, y - 10);
            } 
        }
    }
    
}
