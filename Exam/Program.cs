using Exam.HelperClass;
using Exam.Weapons;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choise;
            do
            {
                Console.WriteLine(">>>>>>>WELCOME TO ARMORY<<<<<<<");
                Console.WriteLine($"[1] - AK-47\n[2] - AWP\n[3] - Deagle\n[4] - UZI\n[0] - Exit game");
                Console.Write($"Select one of the available weapons:");
                choise = Console.ReadLine();
                Console.WriteLine($"-----------------------------------");
                switch (choise)
                {
                    case "1":
                        AK47 ak47 = new AK47(IsAuto.Auto, Helper.WriteBulletCapacity(), Helper.WriteBulletCount());
                        do
                        {
                            Console.WriteLine($"*******AK-47*******");
                            Console.WriteLine($"0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Edit :\r\n7 - Silah deyismek.");
                            Console.Write($"Your select:");
                            choise = Console.ReadLine();
                            Console.WriteLine($"-----------------------------------");
                            switch (choise)
                            {
                                case "0":
                                    ak47.ShowAllProp();
                                    break;
                                case "1":
                                    ak47.Shoot();
                                    break;
                                case "2":
                                    ak47.Fire();
                                    break;
                                case "3":
                                    Console.WriteLine(ak47.GetRemainBulletCount());
                                    break;
                                case "4":
                                    ak47.Reload();
                                    break;
                                case "5":
                                    ak47.ChangeFireMode();
                                    break;
                                case "6":
                                    ak47.BulletCapacity = Helper.WriteBulletCapacity();
                                    ak47.BulletCount = Helper.WriteBulletCount();
                                    break;
                                default:
                                    break;
                            }
                        } while (choise != "7");
                        break;
                    case "2":
                        AWP awp = new AWP(Helper.WriteBulletCapacity(), Helper.WriteBulletCount());
                        do
                        {
                            Console.WriteLine($"*******AWP*******");
                            Console.WriteLine($"0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - GetRemainBulletCount metodu üçün\r\n3 - Reload metodu üçün\r\n4 - Edit :\r\n5 - Silah deyismek.");
                            Console.Write($"Your select:");
                            choise = Console.ReadLine();
                            Console.WriteLine($"-----------------------------------");
                            switch (choise)
                            {
                                case "0":
                                    awp.ShowAllProp();
                                    break;
                                case "1":
                                    awp.Shoot();
                                    break;
                                case "2":
                                    Console.WriteLine(awp.GetRemainBulletCount());
                                    break;
                                case "3":
                                    awp.Reload();
                                    break;
                                case "4":
                                    awp.BulletCapacity = Helper.WriteBulletCapacity();
                                    awp.BulletCount = Helper.WriteBulletCount();
                                    break;
                                default:
                                    break;
                            }
                        } while (choise != "5");
                        break;
                    case "3":
                        Deagle deagle = new Deagle(Helper.WriteBulletCapacity(), Helper.WriteBulletCount());
                        do
                        {
                            Console.WriteLine($"*******Deagle*******");
                            Console.WriteLine($"0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - GetRemainBulletCount metodu üçün\r\n3 - Reload metodu üçün\r\n4 - Edit :\r\n5 - Silah deyismek.");
                            Console.Write($"Your select:");
                            choise = Console.ReadLine();
                            Console.WriteLine($"-----------------------------------");
                            switch (choise)
                            {
                                case "0":
                                    deagle.ShowAllProp();
                                    break;
                                case "1":
                                    deagle.Shoot();
                                    break;
                                    break;
                                case "2":
                                    Console.WriteLine(deagle.GetRemainBulletCount());
                                    break;
                                case "3":
                                    deagle.Reload();
                                    break;
                                case "4":
                                    deagle.BulletCapacity = Helper.WriteBulletCapacity();
                                    deagle.BulletCount = Helper.WriteBulletCount();
                                    break;
                                default:
                                    break;
                            }
                        } while (choise != "5");
                        break;
                    case "4":
                        UZI uzi = new UZI(Helper.WriteBulletCapacity(), Helper.WriteBulletCount());
                        do
                        {
                            Console.WriteLine($"*******UZI*******");
                            Console.WriteLine($"0 - İnformasiya almaq üçün\r\n1 - Fire metodu üçün\r\n2 - GetRemainBulletCount metodu üçün\r\n3 - Reload metodu üçün\r\n4 - Edit :\r\n5 - Silah deyismek.");
                            Console.Write($"Your select:");
                            choise = Console.ReadLine();
                            switch (choise)
                            {
                                case "0":
                                    uzi.ShowAllProp();
                                    break;
                                case "1":
                                    uzi.Fire();
                                    break;
                                case "2":
                                    Console.WriteLine(uzi.GetRemainBulletCount());
                                    break;
                                case "3":
                                    uzi.Reload();
                                    break;
                                case "4":
                                    uzi.BulletCapacity = Helper.WriteBulletCapacity();
                                    uzi.BulletCount = Helper.WriteBulletCount();
                                    break;
                                default:
                                    break;
                            }
                        } while (choise != "5");
                        break;
                    default:
                        break;
                }
            } while (choise != "0");
        }
    }
}