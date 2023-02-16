try
{
    // GATHER IPUT FROM USER
    Console.WriteLine("Por favor, digite uma frase para conveter em um acrônomo:");
    String input = Console.ReadLine();

    // OPTIONALS EXCLUSIONS
    String exclusions = input.Replace("and", "");
    String[] wordArr = exclusions.Split(' ');
    Console.WriteLine(wordArr.Length);

    // LOOP THROUGH SENTENCE
    String acronym = "";
    for (int i = 0; i < wordArr.Length; i++)
    {
        if (wordArr[i] != "")
        {
            acronym += wordArr[i][0];
        }
    }

    acronym = acronym.ToUpper();
    Console.WriteLine("Seu acrônomo é: " + acronym);



} catch(Exception e)
{
    Console.WriteLine(e.ToString());
}