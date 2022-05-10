char[] vowels = { 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
string words = Console.WriteLine("Напишiть текст:");
string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
foreach (string word in words)
{
    if (vowels.Contains(word[0]))
        Console.WriteLine("Слова якi починаються на приголоснi лiтери:" + word);
}
