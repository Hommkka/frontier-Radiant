### UI

# Displayed in the Character prefs window
humanoid-character-profile-summary =
    Это { $name }. { $gender ->
        [male] Ему
        [female] Ей
        [epicene] Им
       *[neuter] Ему
    } { $age } { $age ->
        [one] год
        [few] года
       *[other] лет
    }.
# Height slider
humanoid-character-profile-height = Рост: { $height ->
    [1] Крошечный
    [2] Очень маленький
    [3] Маленький
    [4] Ниже среднего
    [5] Средний
    [6] Выше среднего
    [7] Большой
    [8] Очень большой
    *[other] Титанический
} ({$percent}%)

# Width slider
humanoid-character-profile-width = Ширина: { $width ->
    [1] Тонкий
    [2] Очень худой
    [3] Худой
    [4] Ниже среднего
    [5] Средний
    [6] Выше среднего
    [7] Широкий
    [8] Очень широкий
    *[other] Огромный
} ({$percent}%)
