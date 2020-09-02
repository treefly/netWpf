using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.DesignPattern
{
    /// <summary>
    /// 装饰者模式
    /// </summary>
    public class decorate
    {
        /*
         * 装饰者模式-->
         * 饮料的主题---》某种咖啡
         * 饮料的调料---》装饰
         * 结果的计算---》调用基类进行统计
         * */
         
    }

    /// <summary>
    /// 饮料抽象类
    /// </summary>
    public abstract class Beverage
    {
        public string description = "Unknow Beverage";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }


    /// <summary>
    /// 饮料装饰者 抽象类
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
       public abstract string getDescription();
    }


    #region 实现具体的饮料

    /// <summary>
    /// 浓缩咖啡或者
    /// </summary>
    public class Espresso : Beverage
    {

        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    /// <summary>
    /// 综合咖啡
    /// </summary>
    public class HouseBlend : Beverage
    {

        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double cost()
        {
            return 0.89;
        }

    }
    #endregion



    #region 实现具体的装饰者

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override String getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
        public override double cost()
        {
            return 0.20 + beverage.cost();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override String getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
        public override double cost()
        {
            return 0.50 + beverage.cost();
        }
    }

    /// <summary>
    /// 奶泡
    /// </summary>
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override String getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
        public override double cost()
        {
            return 0.70 + beverage.cost();
        }
    }

    #endregion


    public class StartbuzzCoffee
    {
        public StartbuzzCoffee()
        {
            Beverage beverage1 = new Espresso();
            Console.WriteLine(beverage1.getDescription() + "  $"+ beverage1.cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + "  $" + beverage2.cost());
        }

    }
}
