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
# Height (cm)
humanoid-character-profile-height = Рост: { $cm } см

# Weight (kg)
humanoid-character-profile-width = Вес: { $kg } кг
