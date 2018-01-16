# daw-exam
Web Application Development - Exam Preparation 

DAW Exam in 1, 2, 3

* Create the proper database tables
* Create the C# models in *App_Code/Models/*.
* **The primary key attribute must be set according to the database**
* Models must have the same name as column's, the case may differ.
Example:
<pre>
public class Smartphone
{
    [PrimaryKey]
    public int IDphone { get; set; } 
    public int IDos { get; set; }
    public string name { get; set; }
    public DateTime launchDate { get; set; }
    public string brand { get; set; }
    public string description { get; set; }
}
</pre>

* Go to *Create.aspx* and change the create form according to your new model. You may ignore/delete the dynamic list view population in *Page_Load* event.
* Go to *Manage.aspx* and check the *MaterialTable* control, make sure it's editable.
* On *MaterialTable* and *MaterialRow* change the default model with your defined model.
* On *Page_Load* event from *MaterialTable* you can set search / filter options.

<h2>Bonus: SQLMonkey Example</h2>
<pre>
var monkey = new SQLMonkey(YOUR_CONNECTION_STRING);
var users = monkey.retrieve<User>("users");
// the whole point is to use LINQ in order to speed up the development
var users = monkey.retrieve<User>("users").Where(x => x.name == "John");
monkey.update<User>(user, "users_table_name");
monkey.delete<User>(user, "users_table_name");
 </pre>
