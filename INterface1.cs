using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Interface
{
    interface INterface1//در اینتر فیس ها فقط و فقط دستور ها و قواعد رو مینویسیم . یک اینترفیس نمیتونه دستوری را اجرا کند یا تابعی را عمل کند . متد ها در اینترفیس هیچ گونه سطح دسترسی ماندد پابلیک یا پرایویت ندارند و همچنین چون نمیتوانند عملیاتی را اجرا کنن و فقط قرار داد هستند متد های انها بدنه ندارند.و حتما باید کلاس های های ارث برده از اینترفیس ما همه قوانین درون اینترفیس را اجرا کنند به نحوی. 
    {
        //An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)
        //By default, members of an interface are abstract and public
        //Interfaces can contain properties and methods, but not fields
        //اینتر فیس ها توسط یک کلاس دیگر ایمپلیمنت میشوند
        //موقع ایمپلیمنت متد های اینتر فیس نیازی به کلمه اورراید نیست
        //An interface cannot contain a constructor (as it cannot be used to create objects)

        string hello(string Name);
    }
}
