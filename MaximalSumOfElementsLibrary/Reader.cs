namespace MaximalSumOfElementsLibrary
{
    public class Reader
    {
        public async Task<string[]> ReadFileAsync(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(nameof(filePath));
            }

            using (var fileText = File.ReadAllLinesAsync(filePath))

            return await fileText;            
        }
    }
}
