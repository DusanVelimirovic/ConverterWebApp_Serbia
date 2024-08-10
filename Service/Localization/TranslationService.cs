using System.Globalization;
using System.Text.Json;

namespace Converter_Web_Application.Service.Localization
{
    /// <summary>
    /// Service for handling translations in the application.
    /// </summary>
    public class TranslationService
    {
        private readonly HttpClient _httpClient;
        private readonly Dictionary<string, Dictionary<string, string>> _translations = new();
        public event Action? OnLanguageChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationService"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to fetch translation files.</param>
        public TranslationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Initializes the translation service by fetching translation files.
        /// </summary>
        public async Task InitializeAsync()
        {
            var translationFiles = new[] { "en.json", "fr.json", "it.json", "de.json", "ru.json", "sr.json", "es.json" };
            var cacheBuster = DateTime.Now.Ticks.ToString(); // Unique cache-busting query parameter

            foreach (var file in translationFiles)
            {
                var culture = Path.GetFileNameWithoutExtension(file);
                var response = await _httpClient.GetAsync($"translations/{file}?v={cacheBuster}");
                var content = await response.Content.ReadAsStringAsync();
                var translations = JsonSerializer.Deserialize<Dictionary<string, string>>(content);
                if (translations is not null)
                {
                    _translations[culture] = translations;
                }
            }
        }

        /// <summary>
        /// Translates a given key into the current or specified culture.
        /// </summary>
        /// <param name="key">The translation key.</param>
        /// <param name="culture">The culture to translate to. If null, the current culture is used.</param>
        /// <returns>The translated string or the key if translation is missing.</returns>
        public string Translate(string key, string? culture = null)
        {
            culture ??= CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if (_translations.TryGetValue(culture, out var cultureTranslations) && cultureTranslations.TryGetValue(key, out var translation))
            {
                return translation;
            }
            return key; // Fallback to key if translation is missing
        }

        /// <summary>
        /// Sets the current culture and notifies listeners of the language change.
        /// </summary>
        /// <param name="culture">The culture to set.</param>
        public void SetLanguage(string culture)
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = new CultureInfo(culture);
            OnLanguageChanged?.Invoke();
        }
    }
}
