Console.WriteLine ("What's your name?");
string name = Console.ReadLine ();

if (name.ToLower() == "james") {
    Console.WriteLine ("Look, that's James Bond!");
}
else {
    Console.Write ("Hello, " + name);
}