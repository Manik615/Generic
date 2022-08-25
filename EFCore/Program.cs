using EFCore.Entities;

public class program
{
    public static void Main(string[] args)
    {
        using( var db = new ActorDbContext())
        {
            //db.Actors.AddRange(new Actor() {  AcademyWinner= false, Name="abc", Age = 24 },
            //                   new Actor() {  AcademyWinner = true, Name = "xyz", Age = 29 },
            //                   new Actor() {  AcademyWinner = true, Name = "suv", Age = 30 });
            //var count = db.SaveChanges();
            //Console.WriteLine($"{count} records saved");
            foreach( var Actor in db.Actors)
            {
                Console.WriteLine($"Name: {Actor.Name} \t Id: {Actor.Id}\t Age: {Actor.Age}\t AcademyWinner: {Actor.AcademyWinner}");
            }
            Console.ReadLine();
        }
    }
}