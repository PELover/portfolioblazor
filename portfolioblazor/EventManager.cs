namespace portfolioblazor
{
    public class EventManager
    {
        public event Action? OnLanguageChange;

        public void OnChange()
        {
            OnLanguageChange?.Invoke();
        }
    }
}
