Console.WriteLine("type the first letter of the person you want to look up");
string? input = Console.ReadLine();

var contacts = new List<Contact>
{
new() {Name = "Magnus", Email = "mms@hotmail.com", Location = "Bø, Telemark"},
new() {Name = "Per", Email = "Per@person.com", Location = "Tromsø"},
new() {Name = "Pål", Email = "Pål@pål.pål", Location = "Fredrikstad"},
new() {Name = "Pia", Email = "Pia@piapål.com", Location = "Fredrikstad"},
new() {Name = "Mina", Email = "Mina@minimina.com", Location = "Tønsberg"},
new() {Name = "Elise", Email = "123Elise@hotmail.com", Location = "Bø, Telemark"},


};
var finaList = contacts

.Where(contact => contact.Location == "Fredrikstad" || contact.Location == "Bø, Telemark" || contact.Location == "Tønsberg")
.Where(contact => contact.Name.StartsWith(input, StringComparison.OrdinalIgnoreCase))
.Select(contact => new { Email = contact.Email, Name = contact.Name });

foreach (var person in finaList)
{
    Console.WriteLine($"1Navn 2Epost: 1:{person.Name} 2:{person.Email}");
}


class Contact
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Location { get; set; }
}