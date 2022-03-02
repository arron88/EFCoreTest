// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using ScaffloldTest;

using (demo1Context ctx = new demo1Context())
{
    Person person = new Person();
    person.Name = "lxa";
    person.Age = 10;
    ctx.Persons.Add(person);
    await ctx.SaveChangesAsync();
    var query= ctx.Persons.Where(b=>b.Age<20);
    Console.WriteLine(query.ToQueryString());//日志log ToQueryString 只能查询SQL语句
}
