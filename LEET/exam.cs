using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LEET
{
    
    public class exam
    {
        // 2017完美秋招方块消除
        public class BreakBlock
        {
            public const int RED = 0, GREEN = 1, BLUE = 2, YELLOW = 3, PURPLE = 4;
            public const int NONE = 99;
            public List<List<int>> ops; // input List<int>
            List<int> line = new List<int>();
            public List<int[]> forRemove;
            // 点击后的游戏场景
            private int[,] MAP = new int[10, 10];
            private int[] Mcc = new int[10] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            private int Mr = 10;
            // 输出顺序：红RED 绿GREEN 蓝BLUE 黄YELLOW 紫PURPLE
            public int[] amount = new int[5] { 0, 0, 0, 0, 0 };
            public int[,] p = new int[10, 10] {{RED,RED,BLUE,BLUE,GREEN,YELLOW,BLUE,YELLOW,RED,PURPLE},
                        {GREEN,GREEN,GREEN,BLUE,RED,PURPLE,RED,YELLOW,YELLOW,BLUE},
                        {BLUE,RED,RED,YELLOW,YELLOW,PURPLE,BLUE,GREEN,GREEN,BLUE},
                        {YELLOW,RED,BLUE,YELLOW,BLUE,RED,PURPLE,GREEN,GREEN,RED},
                        {YELLOW,RED,BLUE,BLUE,PURPLE,GREEN,PURPLE,RED,YELLOW,BLUE},
                        {PURPLE,YELLOW,RED,RED,YELLOW,RED,PURPLE,YELLOW,RED,RED},
                        {YELLOW,YELLOW,GREEN,PURPLE,GREEN,RED,BLUE,YELLOW,BLUE,GREEN},
                        {RED,YELLOW,BLUE,BLUE,YELLOW,GREEN,PURPLE,RED,BLUE,GREEN},
                        {GREEN,GREEN,YELLOW,YELLOW,RED,RED,PURPLE,BLUE,BLUE,GREEN},
                        {PURPLE,BLUE,RED,RED,PURPLE,YELLOW,BLUE,RED,RED,GREEN}};
            public BreakBlock()
            {
                ops = new List<List<int>>();
                forRemove = new List<int[]>();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    { 
                        switch (p[i, j])
                        {
                            case RED:
                                amount[RED]++; break;
                            case GREEN:
                                amount[GREEN]++; break;
                            case BLUE:
                                amount[BLUE]++; break;
                            case YELLOW:
                                amount[YELLOW]++; break;
                            case PURPLE:
                                amount[PURPLE]++; break;
                        }
                        // 初始化MAP
                        MAP[i, j] = p[i, j];
                    }
                }
            }
            // for unit test
            public void test_func()
            {
                /***********
                 * test 1  *
                 ***********/
                findClick(1, 1);
                Console.WriteLine(forRemove.Contains(new int[] { 1, 1 }));
                //>> false

                /***********
                 * test 2  *
                 ***********/
                int[] a = mapInput(24);
                Console.WriteLine("{0}, {1}",a[0], a[1]);
                //>> 2, 3

                /***********
                 * test 3  *
                 ***********/
                forRemove.Clear();
                findClick(2, 4);
                for (int i = 0; i < forRemove.Count; i++)
                    Console.Write("({0}, {1}), ", forRemove[i][0], forRemove[i][1]);
                Console.Write("\n");
                //>> (2, 3), (2, 4), (3, 3)

                /***********
                 * test 4  *
                 ***********/
                List<int> c = new List<int>();
                c.Add(1);
                Console.WriteLine(c.Contains(1));
                //>> true

                /***********
                 * test 5  *
                 ***********/
                Console.WriteLine("start: (2, 3): {0}, (2, 4): {1}, (3, 3): {2}", MAP[2, 3], MAP[2, 4], MAP[3, 3]);
                forRemove.Clear();
                findClick(2, 4);
                removeBlock();
                reshapeMap();
                Console.WriteLine("now: (2, 3): {0}, (2, 4): {1}, (3, 3): {2}", MAP[2, 3], MAP[2, 4], MAP[3, 3]);
                Console.WriteLine("now: (0, 3): {0}, (0, 4): {1}, (1, 3): {2}", MAP[0, 3], MAP[0, 4], MAP[1, 3]);
                //>> start: (2, 3): 3, (2, 4): 3, (3, 3): 3
                //   now: (2, 3): 2, (2, 4): 0, (3, 3): 2
                //   now: (0, 3): 99, (0, 4): 99, (1, 3): 99
                /***********
                 * test 6  *
                 ***********/
                Console.WriteLine("start: (0, 5): {0}", MAP[0, 5]);
                forRemove.Clear();
                findClick(0, 5);
                removeBlock();
                reshapeMap();
                Console.WriteLine("now: (0, 5): {0}", MAP[0, 5]);
                //>> start: (0, 5): 3
                //   now: (0, 5): 3
                /***********
                 * test 7  *
                 ***********/
                List<int> b = new List<int>();
                b.Add(6);b.Add(1);
                Console.WriteLine("start: (0, 0): {0}, (0, 1): {1}, start: (0, 5): {2}", MAP[0, 0], MAP[0, 1], MAP[0, 5]);
                int[] output = this.operating(b);
                Console.WriteLine("now: (0, 0): {0}, (0, 1): {1}, start: (0, 5): {2}", MAP[0, 0], MAP[0, 1], MAP[0, 5]);
                for (int i = 0; i < output.Length; i++)
                {
                    Console.Write(output[i]);
                    Console.Write(" ");
                }
                Console.Write("\n");
                //>> start: (0, 0): 0, (0, 1): 0, start: (0, 5): 3
                //   now: (0, 0): 99, (0, 1): 99, start: (0, 5): 3
                //   24 18 22 21 13
                /***********
                 * test 8  *
                 ***********/
                this.inputs();
                for (int i = 0; i < ops.Count; i++)
                {
                    for (int j = 0; j < ops[i].Count; j++)
                    {

                        Console.Write(ops[i][j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                //in>> 6
                //in>> 6 1
                //>> 6
                //>> 6 1

            }
            public void startGame()
            {
                // this.inputs();
                // for (int i = 0; i < ops.Count; i++)
                // {
                //     int[] output = this.operating(ops[i]);
                //     for (int j = 0; j < output.Length; j++)
                //     {
                //         Console.Write(output[j]);
                //         Console.Write(" ");
                //     }
                //     Console.Write("\n");
                // }
                // return;
                // read a line and output
                string str = "";

                str = Console.ReadLine();
                string[] n_m = str.Split();
                
                for (int i = 0; i < n_m.Length; i++)
                {
                    line.Add(Convert.ToInt32(n_m[i]));
                }
                int[] output = this.operating(line);
                for (int j = 0; j < output.Length; j++)
                {
                    Console.Write(output[j]);
                    Console.Write(" ");
                }
                Console.Write("\n");

                
                return;
            }
            // 砖块消除游戏输入 all in once
            public void inputs()
            {
                List<string> inputs = new List<string>();
                string str = "";
                while ((str = Console.ReadLine()) != "")
                {
                    inputs.Add(str);
                }
                for (int i = 0; i < inputs.Count; i++)
                {
                    string[] n_m = inputs[i].Split();
                    List<int> line = new List<int>();
                    for (int j = 0; j < n_m.Length; j++)
                    {
                        line.Add(Convert.ToInt32(n_m[j]));
                    }
                    ops.Add(line);
                }
            }
            private int[] mapInput(int op)
            {
                int[] temp = new int[] { 0, 0 };
                temp[0] = (op - 1) / 10;
                temp[1] = (op - 1) % 10;
                return temp;
            }
            public int[] operating(List<int> ops)
            {
                for (int i = 0; i < ops.Count; i++)
                {
                    if (ops[i] > 100 || ops[i] < 1)
                    {
                        Console.WriteLine("input error!");
                    }
                    int[] pos = mapInput(ops[i]);
                    if (MAP[pos[0], pos[1]] != NONE)
                    {
                        findClick(pos[0], pos[1]);
                        removeBlock();
                        reshapeMap();
                    }
                }
                return amount;
            }
            // find the same blocks
            private void findClick(int x, int y)
            {
                int color = MAP[x, y];
                forRemove.Clear();
                forRemove.Add(new int[] { x, y });
                click_recursion(color, x, y);
                // 无同颜色不消除
                if (forRemove.Count == 1)
                    forRemove.Clear();

                amount[color] -= forRemove.Count;
            }
            private void click_recursion(int color, int x, int y)
            {
                if (x + 1 < 10 && checkListContains(x + 1, y) && isRightBlock(color, x + 1, y))
                {
                    forRemove.Add(new int[] { x + 1, y });
                    click_recursion(color, x + 1, y);
                }
                if (x - 1 >= 0 && checkListContains(x - 1, y) && isRightBlock(color, x - 1, y))
                {
                    forRemove.Add(new int[] { x - 1, y });
                    click_recursion(color, x - 1, y);
                }
                if (y + 1 < 10 && checkListContains(x, y + 1) && isRightBlock(color, x, y + 1))
                {
                    forRemove.Add(new int[] { x, y + 1 });
                    click_recursion(color, x, y + 1);
                }
                if (y - 1 >= 0 && checkListContains(x, y - 1) && isRightBlock(color, x, y - 1))
                {
                    forRemove.Add(new int[] { x, y - 1 });
                    click_recursion(color, x, y - 1);
                }
            }
            private bool isRightBlock(int color, int x, int y)
            {

                if (MAP[x, y] == color)
                    return true;
                return false;
            }
            private bool checkListContains(int x, int y)
            {
                for (int i = 0; i < forRemove.Count; i++)
                {
                    if (forRemove[i][0] == x && forRemove[i][1] == y)
                        return false;
                }
                return true;
            }
            // remove the blocks in MAP 
            private void removeBlock()
            {
                int i = 0;
                while (i < forRemove.Count)
                {
                    MAP[forRemove[i][0],forRemove[i][1]] = NONE;
                    i++;
                }
            }

            // move other blocks
            private void reshapeMap()
            {
                // col by col
                List<int> c = new List<int>();
                Dictionary<int, int> t = new Dictionary<int, int>();
                for (int j = 0; j < forRemove.Count; j++)
                {
                    if (!c.Contains(forRemove[j][1]))
                    {
                        c.Add(forRemove[j][1]);
                        t.Add(forRemove[j][1], 1);
                    }
                    else
                    {
                        t[forRemove[j][1]]++;
                    }
                }
                // move row
                for (int i = 0; i < c.Count; i++)
                {
                    int end = 10 - Mcc[c[i]];
                    for (int r = 9; r >= end; r--)
                    {
                        if (MAP[r,c[i]] == NONE)
                        {
                            for (int j = r; j >= t[c[i]]; j--)
                            {
                                MAP[j, c[i]] = MAP[j - t[c[i]], c[i]];
                            }
                            for (int k = end; k < t[c[i]]; k++)
                                MAP[k, c[i]] = NONE;
                        }
                    }
                    Mcc[c[i]] -= t[c[i]];
                }
                // move col
                for (int i = c.Count - 1; i >= 0; i--)
                {
                    if (Mcc[c[i]] == 0)
                    {
                        for (int j = c[i]; j < Mr - 1; j++)
                            for (int ii = 0; ii < 10; ii++)
                                MAP[ii, j] = MAP[ii, j + 1];
                        Mr--;
                        for (int k = 0; k < 10; k++)
                            MAP[k, Mr] = NONE;
                    }
                }
            }
        }

        // 2018bilibili秋招
        public class Cashapon
        {
            public int count = 0;
            // key->amountNeeded, val->int[0] inputnum, int[1] cas
            Dictionary<int, int[]> p = new Dictionary<int, int[]>();
            public List<int> ops = new List<int>();
            public Cashapon() {}
            private int cas_2(int x)
            {
                return (x - 1) / 2;
            }
            private int cas_3(int x)
            {
                return (x - 2) / 2;
            }
            public void start()
            {
                List<string> inputs = new List<string>();
                string str = "";
                str = Console.ReadLine();
                this.recursion1(Convert.ToInt32(str));
                for (int i = ops.Count - 1; i >= 0; i--)
                {
                    Console.Write(ops[i]);
                    //Console.Write(" ");
                }
            }
            private void recursion1(int num)
            {
                if (num == 0) return;
                else
                {
                    if ((num % 2) == 1)
                    {
                        ops.Add(2);
                        recursion1(cas_2(num));
                    }
                    else
                    {
                        ops.Add(3);
                        recursion1(cas_3(num));
                    }
                }
            }
            public void test_func()
            {
                recursion1(10);
                for (int i = ops.Count - 1; i >= 0; i--)
                {
                    Console.Write(ops[i]);
                }
            }
        }
    }

}