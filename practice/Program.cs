string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

var Selected = words.Select(x =>
    new
    {
        Name = x,
        Length = x.Length // должно быть тоже самое что используется при сортировке
    }
    ).OrderBy( y => y.Length);

foreach( var word in Selected)
{
    Console.WriteLine($"{word.Name} - {word.Length} букв");
}