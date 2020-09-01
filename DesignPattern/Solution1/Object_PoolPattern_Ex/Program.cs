using System;
using System.Collections.Generic;
using System.Collections;

namespace Object_PoolPattern_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init a Simulation");
            Gun gun = new Gun();
            Console.WriteLine("Start");
            gun.Fire();
            Console.WriteLine("Game over!");
            Console.WriteLine("Total bullet created: " + Bullet.Count);
        }
    }
    public class Bullet
    {
        public static int Count = 0;
        public int Position { get; set; }
        public Bullet()
        {
            ++Count;
        }
        public void Move()
        {
            Position++;
        }
    }
    public abstract class MemoryPool<T> where T : Bullet
    {
        LinkedList<Bullet> FreeItems = new LinkedList<Bullet>();
        public void FreeItem(Bullet item)
        {
            FreeItems.AddLast(item);
        }
        protected abstract Bullet Allocate();
        public Bullet NewItem()
        {
            if (FreeItems.Count == 0)
            {
                return Allocate();
            }
            else
            {
                return FreeItems.First.Value;
            }
        }
    }
    class BulletPool : MemoryPool<Bullet>
    {
        protected override Bullet Allocate()
        {
            return new Bullet();
        }
    }
    class Gun
    {
        private int BulletCount = 1000;
        public void FirePool()
        {
            BulletPool bulletPool = new BulletPool();
            List<Bullet> magazine = new List<Bullet>();
            for(int i = 0; i < BulletCount; i++)
            {
                Bullet bullet = bulletPool.NewItem();
                bullet.Position = 0;
                magazine.Add(bullet);
                for(int j = 0; j < magazine.Count; j++)
                {
                    Bullet b2 = magazine[j];
                    b2.Move();
                    Console.WriteLine("-" + b2.Position);
                    if (b2.Position == 10)
                    {
                        magazine.Remove(b2);
                    }
                }
                Console.WriteLine("/");
            }
        }
        public void Fire()
        {
            List<Bullet> magazine = new List<Bullet>();
            for(int i = 0; i < BulletCount; i++)
            {
                Bullet b = new Bullet();
                b.Position = 0;
                magazine.Add(b);
                for(int j = 0; j <magazine.Count; j++)
                {
                    Bullet b2 = magazine[j];
                    b2.Move();
                    Console.WriteLine("-" + b2.Position);
                    if(b2.Position == 10)
                    {
                        magazine.Remove(b2);
                    }
                }
                Console.WriteLine("/");
            }
        }
    }
}
