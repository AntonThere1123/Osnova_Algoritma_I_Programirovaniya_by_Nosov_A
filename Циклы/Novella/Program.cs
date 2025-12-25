using System;

namespace CosmicHorrorExtended
{
    class Program
    {
        static void Main()
        {
            // Основные характеристики
            int cosmicAwareness = 0;      // Осознание (0-100)
            int humanSanity = 100;        // Рассудок (100-0)
            int stationIntegrity = 100;   // Целостность станции (0-100)
            int daysSurvived = 0;         // Пройдено дней
            
            // Дополнительные флаги
            bool journalRead = false;
            bool mirrorBroken = false;
            bool capsuleFound = false;
            bool contactAttempted = false;
            bool reactorEntered = false;
            
            Random random = new Random();
            
            Console.WriteLine("=== ХОРОBОД: ЦИКЛЫ ОСОЗНАНИЯ ===");
            Console.WriteLine("Станция 'Прометей-7', орбита Нептуна, 2157 год\n");
            
            // Главный цикл - 20 дней/итераций
            for (int day = 1; day <= 20; day++)
            {
                daysSurvived = day;
                
                Console.WriteLine($"\n═══════════════════════════════════════");
                Console.WriteLine($"ДЕНЬ {day}");
                Console.WriteLine($"Осознание: {cosmicAwareness} | Рассудок: {humanSanity} | Целостность: {stationIntegrity}%");
                Console.WriteLine($"═══════════════════════════════════════\n");
                
                // Каждый день - новое событие
                switch (day)
                {
                    case 1:
                        Console.WriteLine("[Утро 1-го дня] Вы просыпаетесь от странного гула.");
                        Console.WriteLine("Звук идёт отовсюду и ниоткуда одновременно.");
                        Console.WriteLine("Ваши действия?");
                        Console.WriteLine("1. Проверить системы");
                        Console.WriteLine("2. Осмотреть коридор");
                        Console.WriteLine("3. Проигнорировать и продолжить спать");
                        break;
                        
                    case 2:
                        Console.WriteLine("[День 2] Стены в коридоре покрываются странными узорами.");
                        Console.WriteLine("Они пульсируют в такт вашему сердцебиению.");
                        Console.WriteLine("Что делаете?");
                        Console.WriteLine("1. Изучить узоры");
                        Console.WriteLine("2. Очистить стены");
                        Console.WriteLine("3. Избегать коридор");
                        break;
                        
                    case 3:
                        Console.WriteLine("[День 3] Мониторы показывают фрактальные паттерны.");
                        Console.WriteLine("Они меняются, когда вы на них смотрите.");
                        Console.WriteLine("Как реагируете?");
                        Console.WriteLine("1. Записать данные");
                        Console.WriteLine("2. Выключить мониторы");
                        Console.WriteLine("3. Смотреть до конца");
                        break;
                        
                    case 4:
                        Console.WriteLine("[День 4] Вы находите журнал капитана.");
                        if (!journalRead)
                        {
                            Console.WriteLine("1. Прочитать журнал");
                            Console.WriteLine("2. Оставить как есть");
                            Console.WriteLine("3. Уничтожить журнал");
                        }
                        else
                        {
                            Console.WriteLine("1. Перечитать журнал");
                            Console.WriteLine("2. Искать другие записи");
                            Console.WriteLine("3. Записать свои наблюдения");
                        }
                        break;
                        
                    case 5:
                        Console.WriteLine("[День 5] В иллюминаторе - не Нептун.");
                        Console.WriteLine("Там танцует свет. Он зовёт.");
                        Console.WriteLine("Ваши действия?");
                        Console.WriteLine("1. Подойти ближе");
                        Console.WriteLine("2. Закрыть шторку");
                        Console.WriteLine("3. Зарисовать увиденное");
                        break;
                        
                    case 6:
                        Console.WriteLine("[День 6] Голос в радиоприёмнике.");
                        Console.WriteLine("'ТЫ НЕ ОДИН. МЫ БЫЛИ ЗДЕСЬ ВСЕГДА.'");
                        Console.WriteLine("Как ответите?");
                        Console.WriteLine("1. Попытаться установить связь");
                        Console.WriteLine("2. Выключить радио");
                        Console.WriteLine("3. Спросить 'Кто вы?'");
                        break;
                        
                    case 7:
                        Console.WriteLine("[День 7] Реакторный отсек открыт.");
                        Console.WriteLine("Внутри нет реактора. Только свет и тишина.");
                        Console.WriteLine("Что делаете?");
                        Console.WriteLine("1. Войти в отсек");
                        Console.WriteLine("2. Заблокировать дверь");
                        Console.WriteLine("3. Отправить зонд для исследования");
                        break;
                        
                    case 8:
                        Console.WriteLine("[День 8] Фотографии экипажа.");
                        Console.WriteLine("На всех фото - вы, но с разными именами.");
                        Console.WriteLine("Ваша реакция?");
                        Console.WriteLine("1. Принять эту истину");
                        Console.WriteLine("2. Искать рациональное объяснение");
                        Console.WriteLine("3. Уничтожить фотографии");
                        break;
                        
                    case 9:
                        Console.WriteLine("[День 9] Зеркало в медотсеке.");
                        Console.WriteLine("Отражение движется с задержкой и улыбается.");
                        if (!mirrorBroken)
                        {
                            Console.WriteLine("1. Разбить зеркало");
                            Console.WriteLine("2. Заговорить с отражением");
                            Console.WriteLine("3. Накрыть зеркало тканью");
                        }
                        else
                        {
                            Console.WriteLine("1. Собрать осколки");
                            Console.WriteLine("2. Изучить осколки");
                            Console.WriteLine("3. Оставить как есть");
                        }
                        break;
                        
                    case 10:
                        Console.WriteLine("[День 10] Навигация сломана.");
                        Console.WriteLine("Станция находится между реальностями.");
                        Console.WriteLine("Что предпримете?");
                        Console.WriteLine("1. Попытаться починить навигацию");
                        Console.WriteLine("2. Принять новое положение");
                        Console.WriteLine("3. Отправить сигнал бедствия");
                        break;
                        
                    case 11:
                        Console.WriteLine("[День 11] Капсула криосна найдена.");
                        if (!capsuleFound)
                        {
                            Console.WriteLine("Внутри - вы. Спите и улыбаетесь.");
                            Console.WriteLine("1. Открыть капсулу");
                            Console.WriteLine("2. Наблюдать со стороны");
                            Console.WriteLine("3. Уничтожить капсулу");
                        }
                        else
                        {
                            Console.WriteLine("Капсула пуста. Внутри только свет.");
                            Console.WriteLine("1. Залезть в капсулу");
                            Console.WriteLine("2. Изучить свет");
                            Console.WriteLine("3. Оставить всё как есть");
                        }
                        break;
                        
                    case 12:
                        Console.WriteLine("[День 12] Хоровод говорит с вами напрямую.");
                        Console.WriteLine("'ПРИМИ НАС. СТАНЬ ЦЕЛЫМ.'");
                        Console.WriteLine("Ваш ответ?");
                        Console.WriteLine("1. 'Я принимаю'");
                        Console.WriteLine("2. 'Я отказываюсь'");
                        Console.WriteLine("3. 'Дай мне время'");
                        break;
                        
                    case 13:
                        Console.WriteLine("[День 13] Спасательная капсула активна.");
                        Console.WriteLine("Она может доставить вас на Землю.");
                        Console.WriteLine("Но что-то не так...");
                        Console.WriteLine("1. Подготовить капсулу к полёту");
                        Console.WriteLine("2. Проигнорировать капсулу");
                        Console.WriteLine("3. Разобрать капсулу на запчасти");
                        break;
                        
                    case 14:
                        Console.WriteLine("[День 14] Системы жизнеобеспечения дают сбой.");
                        Console.WriteLine("Воздух становится густым, тяжёлым.");
                        Console.WriteLine("Что делаете?");
                        Console.WriteLine("1. Починить системы");
                        Console.WriteLine("2. Адаптироваться к изменениям");
                        Console.WriteLine("3. Использовать скафандр");
                        break;
                        
                    case 15:
                        Console.WriteLine("[День 15] Время течёт неравномерно.");
                        Console.WriteLine("Часы показывают разные значения.");
                        Console.WriteLine("Как справиться?");
                        Console.WriteLine("1. Положиться на внутренние ритмы");
                        Console.WriteLine("2. Создать новые часы");
                        Console.WriteLine("3. Отказаться от отсчёта времени");
                        break;
                        
                    case 16:
                        Console.WriteLine("[День 16] Вы находите другие 'версии' себя.");
                        Console.WriteLine("Они живут на станции, но в других реальностях.");
                        Console.WriteLine("Ваши действия?");
                        Console.WriteLine("1. Попытаться установить контакт");
                        Console.WriteLine("2. Игнорировать их");
                        Console.WriteLine("3. Исследовать этот феномен");
                        break;
                        
                    case 17:
                        Console.WriteLine("[День 17] Станция начинает 'петь'.");
                        Console.WriteLine("Металл вибрирует, создавая мелодию.");
                        Console.WriteLine("Что делаете?");
                        Console.WriteLine("1. Записать 'пение'");
                        Console.WriteLine("2. Попытаться заглушить звук");
                        Console.WriteLine("3. Присоединиться к 'пению'");
                        break;
                        
                    case 18:
                        Console.WriteLine("[День 18] Границы реальности размываются.");
                        Console.WriteLine("Вы видите сны наяву и реальность во сне.");
                        Console.WriteLine("Как сохранить себя?");
                        Console.WriteLine("1. Вести дневник");
                        Console.WriteLine("2. Создать ритуалы");
                        Console.WriteLine("3. Отдаться течению");
                        break;
                        
                    case 19:
                        Console.WriteLine("[День 19] Хоровод предлагает финальный выбор.");
                        Console.WriteLine("'ВОЙДИ В ТАНЕЦ ИЛИ УЙДИ НАВСЕГДА.'");
                        Console.WriteLine("Что выбираете?");
                        Console.WriteLine("1. Войти в танец");
                        Console.WriteLine("2. Попытаться уйти");
                        Console.WriteLine("3. Остаться наблюдателем");
                        break;
                        
                    case 20:
                        Console.WriteLine("[День 20] Кульминация.");
                        Console.WriteLine("Всё, что было, вело к этому моменту.");
                        Console.WriteLine("Финальное решение:");
                        Console.WriteLine("1. СТАТЬ ХОРОВОДОМ");
                        Console.WriteLine("2. ВЕРНУТЬСЯ ЧЕЛОВЕКОМ");
                        Console.WriteLine("3. УНИЧТОЖИТЬ СТАНЦИЮ");
                        Console.WriteLine("4. ОСТАТЬСЯ МЕЖДУ МИРАМИ");
                        Console.WriteLine("5. СОЗДАТЬ НОВУЮ РЕАЛЬНОСТЬ");
                        break;
                }
                
                // Обработка выбора игрока
                Console.Write("\nВаш выбор (1-5): ");
                string choice = Console.ReadLine();
                
                // В зависимости от дня обрабатываем выбор
                ProcessChoice(day, choice, ref cosmicAwareness, ref humanSanity, 
                            ref stationIntegrity, ref journalRead, ref mirrorBroken, 
                            ref capsuleFound, ref contactAttempted, ref reactorEntered);
                
                // Случайные события
                if (random.Next(1, 101) <= 30) // 30% шанс случайного события
                {
                    RandomEvent(ref cosmicAwareness, ref humanSanity, ref stationIntegrity, day);
                }
                
                // Проверка на преждевременную концовку
                if (CheckEarlyEnding(cosmicAwareness, humanSanity, stationIntegrity, day))
                {
                    ShowEnding(cosmicAwareness, humanSanity, stationIntegrity, daysSurvived, 
                              journalRead, mirrorBroken, capsuleFound, contactAttempted, reactorEntered);
                    return;
                }
                
                // Естественная деградация
                if (day > 5) humanSanity -= random.Next(1, 5);
                if (day > 10) stationIntegrity -= random.Next(1, 3);
                
                // Ограничиваем значения
                cosmicAwareness = Math.Clamp(cosmicAwareness, 0, 100);
                humanSanity = Math.Clamp(humanSanity, 0, 100);
                stationIntegrity = Math.Clamp(stationIntegrity, 0, 100);
            }
            
            // Если дошли до конца 20 дней
            ShowEnding(cosmicAwareness, humanSanity, stationIntegrity, daysSurvived,
                      journalRead, mirrorBroken, capsuleFound, contactAttempted, reactorEntered);
        }
        
        static void ProcessChoice(int day, string choice, ref int cosmicAwareness, ref int humanSanity,
                                 ref int stationIntegrity, ref bool journalRead, ref bool mirrorBroken,
                                 ref bool capsuleFound, ref bool contactAttempted, ref bool reactorEntered)
        {
            Random random = new Random();
            
            switch (day)
            {
                case 1:
                    if (choice == "1") { cosmicAwareness += 10; humanSanity -= 5; }
                    else if (choice == "2") { cosmicAwareness += 5; humanSanity -= 10; }
                    else { humanSanity += 5; }
                    break;
                    
                case 2:
                    if (choice == "1") { cosmicAwareness += 15; humanSanity -= 10; }
                    else if (choice == "2") { stationIntegrity -= 5; humanSanity += 5; }
                    else { humanSanity += 3; }
                    break;
                    
                case 3:
                    if (choice == "1") { cosmicAwareness += 20; humanSanity -= 15; }
                    else if (choice == "2") { humanSanity += 10; }
                    else { cosmicAwareness += 30; humanSanity -= 25; }
                    break;
                    
                case 4:
                    if (choice == "1") 
                    { 
                        journalRead = true;
                        cosmicAwareness += 25; 
                        humanSanity -= 20; 
                    }
                    else if (choice == "2") { humanSanity += 5; }
                    else { cosmicAwareness -= 10; humanSanity += 15; }
                    break;
                    
                case 5:
                    if (choice == "1") { cosmicAwareness += 40; humanSanity -= 35; }
                    else if (choice == "2") { humanSanity += 15; }
                    else { cosmicAwareness += 20; humanSanity -= 10; }
                    break;
                    
                case 6:
                    if (choice == "1") 
                    { 
                        contactAttempted = true;
                        cosmicAwareness += 15; 
                        humanSanity -= 20; 
                    }
                    else if (choice == "2") { humanSanity += 10; }
                    else { cosmicAwareness += 30; humanSanity -= 25; }
                    break;
                    
                case 7:
                    if (choice == "1") 
                    { 
                        reactorEntered = true;
                        cosmicAwareness += 50; 
                        humanSanity -= 40; 
                    }
                    else if (choice == "2") { stationIntegrity -= 10; humanSanity += 20; }
                    else { cosmicAwareness += 10; }
                    break;
                    
                case 8:
                    if (choice == "1") { cosmicAwareness += 35; humanSanity -= 30; }
                    else if (choice == "2") { humanSanity += 15; cosmicAwareness -= 10; }
                    else { humanSanity -= 20; stationIntegrity -= 5; }
                    break;
                    
                case 9:
                    if (choice == "1") 
                    { 
                        mirrorBroken = true;
                        cosmicAwareness += 25; 
                        humanSanity -= 20; 
                        stationIntegrity -= 5;
                    }
                    else if (choice == "2") { cosmicAwareness += 40; humanSanity -= 35; }
                    else { humanSanity += 10; }
                    break;
                    
                case 10:
                    if (choice == "1") { humanSanity += 15; stationIntegrity -= 10; }
                    else if (choice == "2") { cosmicAwareness += 30; humanSanity -= 25; }
                    else { contactAttempted = true; humanSanity -= 20; }
                    break;
                    
                case 11:
                    if (choice == "1") 
                    { 
                        capsuleFound = true;
                        cosmicAwareness += 60; 
                        humanSanity -= 50; 
                    }
                    else if (choice == "2") { cosmicAwareness += 20; }
                    else { humanSanity += 30; cosmicAwareness -= 40; }
                    break;
                    
                case 12:
                    if (choice == "1") { cosmicAwareness += 70; humanSanity = Math.Max(0, humanSanity - 60); }
                    else if (choice == "2") { humanSanity += 40; cosmicAwareness -= 30; }
                    else { cosmicAwareness += 10; humanSanity -= 10; }
                    break;
                    
                case 13:
                    if (choice == "1") { humanSanity += 30; stationIntegrity -= 15; }
                    else if (choice == "2") { cosmicAwareness += 20; }
                    else { stationIntegrity -= 20; cosmicAwareness += 10; }
                    break;
                    
                case 14:
                    if (choice == "1") { stationIntegrity += 20; humanSanity += 10; }
                    else if (choice == "2") { cosmicAwareness += 25; humanSanity -= 15; }
                    else { humanSanity += 5; }
                    break;
                    
                case 15:
                    if (choice == "1") { cosmicAwareness += 20; }
                    else if (choice == "2") { humanSanity += 15; }
                    else { cosmicAwareness += 30; humanSanity -= 20; }
                    break;
                    
                case 16:
                    if (choice == "1") { cosmicAwareness += 35; humanSanity -= 25; }
                    else if (choice == "2") { humanSanity += 20; }
                    else { cosmicAwareness += 25; }
                    break;
                    
                case 17:
                    if (choice == "1") { cosmicAwareness += 15; }
                    else if (choice == "2") { humanSanity += 10; stationIntegrity -= 5; }
                    else { cosmicAwareness += 40; humanSanity -= 30; }
                    break;
                    
                case 18:
                    if (choice == "1") { humanSanity += 25; }
                    else if (choice == "2") { humanSanity += 15; }
                    else { cosmicAwareness += 35; humanSanity -= 20; }
                    break;
                    
                case 19:
                    if (choice == "1") { cosmicAwareness += 50; humanSanity -= 40; }
                    else if (choice == "2") { humanSanity += 35; cosmicAwareness -= 20; }
                    else { cosmicAwareness += 20; }
                    break;
                    
                case 20:
                    if (choice == "1") { cosmicAwareness = 100; humanSanity = 0; }
                    else if (choice == "2") { humanSanity = Math.Min(100, humanSanity + 50); cosmicAwareness = Math.Max(0, cosmicAwareness - 30); }
                    else if (choice == "3") { stationIntegrity = 0; humanSanity += 40; cosmicAwareness = 0; }
                    else if (choice == "4") { cosmicAwareness = 50; humanSanity = 50; }
                    else if (choice == "5") { cosmicAwareness = 80; humanSanity = 20; }
                    break;
            }
        }
        
        static void RandomEvent(ref int cosmicAwareness, ref int humanSanity, ref int stationIntegrity, int day)
        {
            Random random = new Random();
            int eventType = random.Next(1, 7);
            
            Console.WriteLine("\n[Случайное событие!]");
            
            switch (eventType)
            {
                case 1:
                    Console.WriteLine("Стены прошептали вам секрет вселенной.");
                    cosmicAwareness += random.Next(5, 15);
                    humanSanity -= random.Next(3, 8);
                    break;
                    
                case 2:
                    Console.WriteLine("Системный сбой. Что-то важное сломалось.");
                    stationIntegrity -= random.Next(5, 15);
                    humanSanity -= random.Next(2, 6);
                    break;
                    
                case 3:
                    Console.WriteLine("Момент ясности. Вы вспомнили что-то важное.");
                    humanSanity += random.Next(5, 15);
                    break;
                    
                case 4:
                    Console.WriteLine("Хоровод приблизился. Его присутствие ощутимо.");
                    cosmicAwareness += random.Next(10, 20);
                    humanSanity -= random.Next(5, 12);
                    break;
                    
                case 5:
                    Console.WriteLine("Найдены припасы. Небольшая передышка.");
                    humanSanity += random.Next(3, 8);
                    stationIntegrity += random.Next(2, 6);
                    break;
                    
                case 6:
                    Console.WriteLine("Время исказилось. Вы потеряли счёт часам.");
                    cosmicAwareness += random.Next(8, 16);
                    humanSanity -= random.Next(4, 10);
                    break;
            }
        }
        
        static bool CheckEarlyEnding(int cosmicAwareness, int humanSanity, int stationIntegrity, int day)
        {
            if (humanSanity <= 0 && day < 20) return true;
            if (stationIntegrity <= 0 && day < 20) return true;
            if (cosmicAwareness >= 90 && day < 15) return true;
            if (humanSanity >= 90 && cosmicAwareness <= 10 && day > 10) return true;
            
            return false;
        }
        
        static void ShowEnding(int cosmicAwareness, int humanSanity, int stationIntegrity, int daysSurvived,
                              bool journalRead, bool mirrorBroken, bool capsuleFound, 
                              bool contactAttempted, bool reactorEntered)
        {
            Console.WriteLine("\n\n═══════════════════════════════════════");
            Console.WriteLine("         К О Н Е Ц   И С Т О Р И И");
            Console.WriteLine("═══════════════════════════════════════\n");
            
            Console.WriteLine($"Прожито дней: {daysSurvived}/20");
            Console.WriteLine($"Осознание Хоровода: {cosmicAwareness}%");
            Console.WriteLine($"Сохранённый рассудок: {humanSanity}%");
            Console.WriteLine($"Целостность станции: {stationIntegrity}%\n");
            
            // Определение концовки
            string ending = "";
            
            // 10 КОНЦОВОК
            if (cosmicAwareness >= 95 && humanSanity <= 5)
            {
                ending = @"
КОНЦОВКА 1: ВЕЧНЫЙ ТАНЕЦ
Вы стали Хороводом. Ваше сознание расширилось до космических масштабов.
Вы танцуете среди звёзд, вечный и бесконечный.
Человечество было лишь сном, от которого вы наконец проснулись.
Вы свободны. Вы целы. Вы - всё.";
            }
            else if (humanSanity >= 90 && cosmicAwareness <= 10 && stationIntegrity >= 50)
            {
                ending = @"
КОНЦОВКА 2: ВОЗВРАЩЕНИЕ ГЕРОЯ
Вы вернулись на Землю с доказательствами аномалии.
Ваш отчёт изменил науку навсегда. Вас чествуют как героя.
Но по ночам вы слышите эхо Хоровода, зовущее вас обратно...";
            }
            else if (cosmicAwareness >= 70 && humanSanity >= 40 && stationIntegrity >= 30)
            {
                ending = @"
КОНЦОВКА 3: МОСТ МЕЖДУ МИРАМИ
Вы остались на станции, став проводником между человечеством и Хороводом.
К вам приходят учёные, философы, искатели истины.
Вы объясняете необъяснимое, являясь живым мостом между реальностями.";
            }
            else if (humanSanity <= 15 && stationIntegrity <= 20)
            {
                ending = @"
КОНЦОВКА 4: ПОСЛЕДНИЙ ОБИТАТЕЛЬ
Станция разрушается вокруг вас, но вы остаётесь.
Ваш разум разорван между реальностью и безумием.
Вы становитесь призраком Прометея-7, вечным стражем руин.";
            }
            else if (cosmicAwareness >= 50 && humanSanity >= 60 && capsuleFound && reactorEntered)
            {
                ending = @"
КОНЦОВКА 5: СОЗДАТЕЛЬ НОВОЙ РЕАЛЬНОСТИ
Вы использовали знания Хоровода, чтобы создать новую реальность.
На обломках станции возникла новая форма существования.
Вы не бог, но и не человек - вы нечто новое, первый житель новой вселенной.";
            }
            else if (humanSanity >= 80 && contactAttempted && !mirrorBroken)
            {
                ending = @"
КОНЦОВКА 6: УЧЁНЫЙ-СОЗЕРЦАТЕЛЬ
Вы вернулись с огромным массивом данных. Став ведущим экспертом по аномалиям,
вы помогаете человечеству понять космические угрозы, оставаясь на безопасном расстоянии.
Знание без поглощения - ваша философия.";
            }
            else if (cosmicAwareness >= 85 && journalRead && mirrorBroken)
            {
                ending = @"
КОНЦОВКА 7: РАЗБИТОЕ ЗЕРКАЛО
Вы приняли истину Хоровода, но ваше принятие было насильственным, болезненным.
Теперь вы - ходячее противоречие, существо из осколков разных реальностей.
Каждый осколок зеркала показывает другую версию вас, и все они настоящие.";
            }
            else if (stationIntegrity <= 10 && daysSurvived < 15)
            {
                ending = @"
КОНЦОВКА 8: ЖЕРТВА ТЕХНОЛОГИЙ
Станция разрушилась, унеся вас в космическую пустоту.
Ваше последнее сообщение стало легендой, предостережением для будущих экспедиций.
Вы погибли, но ваша смерть спасла countless других.";
            }
            else if (cosmicAwareness <= 20 && humanSanity <= 30 && daysSurvived >= 18)
            {
                ending = @"
КОНЦОВКА 9: ЗАТОЧНИК БЕЗДНЫ
Вы застряли между мирами, не приняв Хоровод, но и не вернувшись к человечеству.
Станция стала вашей вечной тюрьмой, а вы - её вечным стражником.
Время потеряло смысл, но долг остался.";
            }
            else
            {
                ending = @"
КОНЦОВКА 10: НЕИЗВЕСТНЫЙ ИСХОД
Что случилось с вами, никто не знает. Станция исчезла без следа.
Одни говорят, вы стали звёздами. Другие - что провалились в небытие.
Ваша судьба осталась тайной, как и сам Хоровод.";
            }
            
            Console.WriteLine(ending);
            
            // Дополнительная информация о прохождении
            Console.WriteLine("\n═══════════════════════════════════════");
            Console.WriteLine("           Д О С Т И Ж Е Н И Я");
            Console.WriteLine("═══════════════════════════════════════");
            
            if (journalRead) Console.WriteLine("✓ Прочитан журнал капитана");
            if (mirrorBroken) Console.WriteLine("✓ Разбито зеркало");
            if (capsuleFound) Console.WriteLine("✓ Найдена капсула криосна");
            if (contactAttempted) Console.WriteLine("✓ Попытка связи с Землёй");
            if (reactorEntered) Console.WriteLine("✓ Посещён реакторный отсек");
            
            Console.WriteLine("\nСпасибо за игру!");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}