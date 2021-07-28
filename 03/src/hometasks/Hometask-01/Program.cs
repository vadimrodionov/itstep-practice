using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UdincevBogdan.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;
            int protT = 0;

            int sizeTeam = 0;
            List<Worker> workers = new List<Worker>();
            TeamLeader teamLeader = null;
            Team team = new Team(workers, teamLeader);
            House house = new House();

            do
            {
                Console.WriteLine("0. �����.");
                Console.WriteLine("1. �������� ����� �������.");
                Console.WriteLine("2. ���������� � �������.");
                Console.WriteLine("3. ��������� ���");
                Console.WriteLine("4. ������� �����");
                Console.Write("�������� ��������: "); key = Console.ReadKey().KeyChar; Console.Clear();
                switch (key)
                {
                    case '1':
                        {
                            if (protT == 0)
                            {
                                Console.Write("������� ������ �������: "); sizeTeam = int.Parse(Console.ReadLine());
                                if (sizeTeam > 2)
                                {
                                    Console.Write("������� ��� ���������: "); teamLeader = new TeamLeader(Console.ReadLine());
                                }
                                else
                                {
                                    teamLeader = null;
                                    sizeTeam++;
                                }
                                for (int i = 0; i < sizeTeam - 1; i++)
                                {
                                    Console.Write($"������� ��� �������� �{ i + 1 }: "); workers.Add(new Worker(Console.ReadLine()));
                                }
                                team = new Team(workers, teamLeader);
                                Console.WriteLine("������� �������! ��� ������ ������� ����� �������..."); Console.ReadKey(); Console.Clear();
                                protT++;
                            }
                            else
                            {
                                Console.WriteLine("������ ������� ������ ��������!\n��� ������ ������� ����� �������..."); Console.ReadKey(); Console.Clear();
                            }
                        }
                        break;
                    case '2':
                        {
                            if (sizeTeam != 0)
                            {
                                if (TeamLeader.Name != null)
                                {
                                    Console.WriteLine($"����� �������: {TeamLeader.Name}");
                                }
                                for (int i = 0; i < workers.Count; i++)
                                {
                                    Console.WriteLine($"������� �{i + 1}: {workers[i].Name}");
                                }
                            }
                            else Console.WriteLine("������� �� �������!");
                            Console.WriteLine("��� ������ ������� ����� �������..."); Console.ReadKey(); Console.Clear();
                        }
                        break;
                    case '3':
                        {
                            if (team.report.Count != 11 && sizeTeam != 0)
                            {
                                char key2;
                                Console.WriteLine("������� 1 ����� ������� ���. ����� ����� ������� 0");
                                do
                                {
                                    key2 = Console.ReadKey().KeyChar;
                                    if (key2 == '1')
                                    {
                                        house.Build(house, team);
                                        Console.WriteLine(team.report.Count);
                                    }
                                    else if (key2 == '0') break;
                                    if (team.report.Count == 11)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("��� ��� ��������!");
                                        house.Paint();
                                        break;
                                    }
                                } while (key2 != '0');
                                Console.WriteLine("��� ������ ������� ����� �������..."); Console.ReadKey(); Console.Clear();
                            }
                            else if (team.report.Count == 11)
                            {
                                Console.WriteLine("��� ��� ��������!"); house.Paint();
                                Console.WriteLine("��� ������ ������� ����� �������..."); Console.ReadKey(); Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("������� �� �������!");
                                Console.WriteLine("��� ������ ������� ����� �������..."); Console.ReadKey(); Console.Clear();
                            }

                        }
                        break;
                    case '4':
                        {
                            if (sizeTeam != 0 && team.report.Count > 0)
                            {
                                foreach (var i in team.report)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            else Console.WriteLine("��� ��� �� ��������!");
                            Console.WriteLine("��� ������ ������� ����� �������..."); Console.ReadKey(); Console.Clear();
                        }
                        break;
                }
            } while (key != '0');
        }
    }
}
