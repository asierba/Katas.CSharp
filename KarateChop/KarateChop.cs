namespace KarateChop
{
    public static class KarateChop
    {
        public static int Find(int itemToFind, int[] items)
        {
            const int notFound = -1;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == itemToFind)
                    return i;
            }

            return notFound;
        }
    }
}