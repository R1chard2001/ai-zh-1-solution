﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class BreadthFirst : ASolver
    {
        public Queue<Node> OpenNodes = new Queue<Node>();
        public List<Node> ClosedNodes = new List<Node>();
        public BreadthFirst() : base()
        {
        }
        public override Operator SelectOperator()
        {
            int index = CurrentNode.OperatorIndex++;
            while (index < Operators.Count)
            {
                if (Operators[index].IsAplicable(CurrentNode.State))
                {
                    return Operators[index];
                }
                index = CurrentNode.OperatorIndex++;
            }
            return null;
        }
        Node CurrentNode;
        public Node Path;

        public override void Solve()
        {
            OpenNodes.Clear();
            ClosedNodes.Clear();
            Path = null;
            OpenNodes.Enqueue(new Node(new State()));
            while (0 < OpenNodes.Count)
            {
                CurrentNode = OpenNodes.Dequeue();
                ClosedNodes.Add(CurrentNode);
                Operator selectedOperator = SelectOperator();
                while (selectedOperator != null)
                {
                    State newState = selectedOperator.Apply(CurrentNode.State);
                    Node newNode = new Node(newState, CurrentNode);
                    if (newNode.IsTargetNode())
                    {
                        Path = newNode;
                        break;
                    }
                    if (!OpenNodes.Contains(newNode) && !ClosedNodes.Contains(newNode))
                    {
                        OpenNodes.Enqueue(newNode);
                    }
                    selectedOperator = SelectOperator();
                }
                
            }
            if (Path != null)
            {
                Console.WriteLine("Found a path to targetstate.");
                Console.WriteLine("----------------------------");
                Console.WriteLine(Path);
            }
            else
            {
                Console.WriteLine("Cant solve the problem!");
            }
        }
    }
}
