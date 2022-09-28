using FluentEmail.Core;

namespace Project1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Code";

        /*
         * Can come from a file
         */
        string template = @"
<html>
 <body>
  <h1><%= ##Name## %></h1>
  <p>On <%=##Date##%> you are required to change your password</p>
  <p>Any questions contact ##Contact##</p>
 </body>
</html>
";

        var email = Email
            .From("fromEmail")
            .To("toEmail")
            .Subject("subject")
            .UsingTemplate(template, new
            {
                Name = "Mary Sue", 
                Date = new DateTime(2022,10,12).ToString("d"),
                Contact = "Bill Jones (504) 999-1234"
            });

        Console.WriteLine(email.Data.Body); // for body of email
        Console.ReadLine();
    }
}

