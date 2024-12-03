namespace WebApplication1;

public static class FakeData
{
    public static List<NewsDTO> NEWS = new List<NewsDTO>();
    
    public static UserDTO USER = new UserDTO(){Name ="John Doe"};

    static FakeData()
    {
        NEWS = new List<NewsDTO>
        {
            new NewsDTO
            {
                Id = Guid.NewGuid(),
                Title = "Новое обновление платформы",
                Description = "Вышло новое обновление с улучшенными функциями безопасности.",
                Content = "Сегодня компания объявила о выпуске обновления, которое включает в себя усовершенствованные меры безопасности и повышенную производительность системы."
            },
            new NewsDTO
            {
                Id = Guid.NewGuid(),
                Title = "Событие для разработчиков",
                Description = "Готовится большое событие для разработчиков со всего мира.",
                Content = "На следующей неделе пройдет ежегодное событие для разработчиков, где будут представлены новейшие технологии и инструменты разработки."
            },
            new NewsDTO
            {
                Id = Guid.NewGuid(),
                Title = "Интервью с техническим директором",
                Description = "Технический директор рассказал о будущем компании.",
                Content = "В недавнем интервью технический директор поделился своими мыслями о будущем технологий и видении компании на следующие годы."
            },
            new NewsDTO
            {
                Id = Guid.NewGuid(),
                Title = "Запуск нового продукта",
                Description = "Компания представила новый продукт, предназначенный для малого бизнеса.",
                Content = "Новый продукт ориентирован на облегчение управления малым бизнесом и включает функциональные возможности для учета и анализа данных."
            },
            new NewsDTO
            {
                Id = Guid.NewGuid(),
                Title = "Исследование в области ИИ",
                Description = "Обнародованы результаты нового исследования в области искусственного интеллекта.",
                Content = "Недавно проведенное исследование показало потенциальные пути развития технологий искусственного интеллекта и возможности их применения в различных сферах."
            }
        };
    }

}