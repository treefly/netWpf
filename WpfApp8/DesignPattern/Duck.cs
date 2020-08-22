using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.DesignPattern
{

    /// <summary>
    /// 策略模式
    /// </summary>
    abstract class Duck
    {

        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;


        public string Name;

        //抽象属性必须为公有
        public abstract string area { get; set; }

        /// <summary>
        /// 抽象方法 游泳
        /// </summary>
        public void Swim() { }

        public abstract void  Dispaly();

        public void performFly()
        {
            flyBehavior.Fly();
        }

        public  void performQuack()
        {
            quackBehavior.Quack();
        }


        public void SetFly(FlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuack(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
    }

    public interface FlyBehavior
    {
         void Fly();
    }

    public interface QuackBehavior
    {
        void Quack();
    }


    public class FlyWiathWings : FlyBehavior
    {
        void FlyBehavior.Fly()
        {
           
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            
        }
    }

    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            
        }
    }

    public class FackeQuack : QuackBehavior
    {
        public void Quack()
        {
           
        }
    }
}
