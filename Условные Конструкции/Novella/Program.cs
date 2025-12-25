using System;

namespace CosmicHorror
{
    class Program
    {
        static void Main()
        {
            int cosmicAwareness = 0; // Осознание истины (0-100)
            int humanSanity = 100;   // Человеческая связь (100-0)
            string answer;
            
            // ШАГ 1
            Console.WriteLine("=== СТАНЦИЯ 'ПРОМЕТЕЙ-7' ===");
            Console.WriteLine("Дата: 2157 год");
            Console.WriteLine("Местоположение: Орбита Нептуна");
            Console.WriteLine("Миссия: Исследование аномалии 'Хоровод'");
            
            Console.WriteLine("\n[1] Вы просыпаетесь от звука сирены.");
            Console.WriteLine("Не аварийной — это монотонный, почти музыкальный гул.");
            Console.WriteLine("Он пронизывает металл станции.");
            Console.WriteLine("Ваши действия? (проверить системы/выйти в коридор/остаться)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("проверить") || answer.Contains("системы"))
            {
                Console.WriteLine("\nВы подходите к консоли. Данные в норме, кроме одного показателя.");
                Console.WriteLine("ГРАВИТАЦИОННЫЕ АНОМАЛИИ: 147%");
                Console.WriteLine("Это невозможно. Станция не в черной дыре.");
                cosmicAwareness += 10;
                humanSanity -= 5;
            }
            else if (answer.Contains("коридор") || answer.Contains("выйти"))
            {
                Console.WriteLine("\nКоридор пуст. Слишком пуст.");
                Console.WriteLine("Обычно здесь至少 два члена экипажа дежурят.");
                Console.WriteLine("Стены излучают слабый биолюминесцентный свет.");
                cosmicAwareness += 5;
                humanSanity -= 10;
            }
            
            // ШАГ 2
            Console.WriteLine("\n[2] Вы замечаете на стене надпись:");
            Console.WriteLine("'ОН НЕ СПИТ. ОН СМОТРИТ. ОН ЖДЕТ.'");
            Console.WriteLine("Чей-то почерк. Ваш? (стереть/сфотографировать/прикоснуться)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("стереть"))
            {
                Console.WriteLine("\nВы пытаетесь стереть надпись.");
                Console.WriteLine("Буквы не стираются. Они будто вросли в металл.");
                Console.WriteLine("Ваши пальцы ощущают слабую пульсацию под поверхностью.");
                cosmicAwareness += 15;
                humanSanity -= 15;
            }
            else if (answer.Contains("прикоснуться"))
            {
                Console.WriteLine("\nВы касаетесь букв. Металл теплый, почти телесный.");
                Console.WriteLine("В ушах возникает шепот: 'Ты уже видел. Ты просто забыл.'");
                cosmicAwareness += 25;
                humanSanity -= 20;
            }
            
            // ШАГ 3
            Console.WriteLine("\n[3] В научном отсеке все мониторы показывают одно:");
            Console.WriteLine("ФРАКТАЛЬНЫЕ ПАТТЕРНЫ. Бесконечно сложные узоры.");
            Console.WriteLine("Изучить данные? (да/нет/уничтожить мониторы)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("да") || answer.Contains("изучить"))
            {
                Console.WriteLine("\nЧем дольше вы смотрите, тем больше понимаете:");
                Console.WriteLine("это не просто узоры. Это карта.");
                Console.WriteLine("Карта чего-то за пределами станции.");
                cosmicAwareness += 30;
                humanSanity -= 25;
                
                // ШАГ 4
                Console.WriteLine("\n[4] Паттерны начинают складываться в лица.");
                Console.WriteLine("Лица экипажа. Они молчат, но их глаза...");
                Console.WriteLine("Что делаете? (закрыть глаза/смотреть дальше/разбить экран)");
                answer = Console.ReadLine().ToLower();
                
                if (answer.Contains("смотреть"))
                {
                    Console.WriteLine("\nВы видите истину: они не умерли.");
                    Console.WriteLine("Они стали частью Хоровода.");
                    cosmicAwareness += 40;
                    humanSanity -= 35;
                }
            }
            
            // ШАГ 5
            Console.WriteLine("\n[5] Вы находите личный журнал капитана Ивановой.");
            Console.WriteLine("Последняя запись: 'Оно поёт. И мы начинаем слышать.'");
            Console.WriteLine("Читать с начала? (да/нет/сжечь журнал)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("да"))
            {
                Console.WriteLine("\nВы читаете о первых днях аномалии:");
                Console.WriteLine("'День 12: Хоровод приближается. Он красив.'");
                Console.WriteLine("'День 45: Экипаж перестал спать. Они слушают.'");
                cosmicAwareness += 20;
                humanSanity -= 15;
            }
            
            // ШАГ 6
            Console.WriteLine("\n[6] Иллюминатор показывает не Нептун.");
            Console.WriteLine("Там танцуют цвета, которых нет в спектре.");
            Console.WriteLine("Подойти ближе? (да/нет/закрыть шторку)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("да"))
            {
                Console.WriteLine("\nТо, что вы видите, невозможно описать словами.");
                Console.WriteLine("Это больше, чем объект. Больше, чем существо.");
                Console.WriteLine("И он смотрит на вас. Знает вас.");
                cosmicAwareness += 50;
                humanSanity -= 40;
            }
            
            // ШАГ 7
            Console.WriteLine("\n[7] Система связи оживает. Голос без источника:");
            Console.WriteLine("'ПРИСОЕДИНЯЙСЯ К ХОРОВОДУ. ОДИНОЧЕСТВО — БОЛЬ.'");
            Console.WriteLine("Ответить? (да/нет/попытаться установить связь с Землей)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("ответить") || answer == "да")
            {
                Console.WriteLine("\nВы говорите: 'Кто ты?'");
                Console.WriteLine("Голос отвечает: 'МЫ — ТО, ЧТО БЫЛО ДО ЗВЕЗД.'");
                cosmicAwareness += 35;
                humanSanity -= 30;
            }
            else if (answer.Contains("земл") || answer.Contains("земля"))
            {
                Console.WriteLine("\nВы пытаетесь вызвать Землю.");
                Console.WriteLine("Ответ приходит через 8 часов:");
                Console.WriteLine("'СТАНЦИЯ ПРОМЕТЕЙ-7 УНИЧТОЖЕНА 2 ГОДА НАЗАД.'");
                humanSanity -= 50;
            }
            
            // ШАГ 8
            Console.WriteLine("\n[8] Дверь в реакторный отсек открывается сама.");
            Console.WriteLine("Внутри нет реактора. Есть только свет.");
            Console.WriteLine("Войти? (войти/остаться/попытаться восстановить контроль)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("войти"))
            {
                Console.WriteLine("\nСвет обнимает вас. Не жжет — ласкает.");
                Console.WriteLine("Вы понимаете все: рождение звезд, смерть галактик.");
                cosmicAwareness = 100;
                humanSanity = 0;
            }
            
            // ШАГ 9
            Console.WriteLine("\n[9] Вы находите комнату с фотографиями экипажа.");
            Console.WriteLine("На всех фото - один и тот же человек с разными именами.");
            Console.WriteLine("И это вы. Все 12 членов экипажа - это вы.");
            Console.WriteLine("Как реагируете? (принять/отрицать/разрушить доказательства)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("принять"))
            {
                Console.WriteLine("\nВы всегда были один. Экипаж был иллюзией.");
                Console.WriteLine("Компания знала. Они послали вас одного.");
                cosmicAwareness += 45;
                humanSanity -= 40;
            }
            else if (answer.Contains("отрицать"))
            {
                Console.WriteLine("\nНет, это невозможно. Вы помните их голоса.");
                Console.WriteLine("Их смех. Их лица. Но память начинает тускнеть...");
                humanSanity -= 35;
            }
            
            // ШАГ 10
            Console.WriteLine("\n[10] В медотсеке вы находите зеркало.");
            Console.WriteLine("Ваше отражение движется с задержкой в 3 секунды.");
            Console.WriteLine("Оно улыбается вам так, как вы не улыбались никогда.");
            Console.WriteLine("Что делаете? (разбить зеркало/заговорить/уйти)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("разбить"))
            {
                Console.WriteLine("\nЗеркало бьется. Осколки показывают тысячи вас.");
                Console.WriteLine("Все они смотрят на вас. Все улыбаются.");
                cosmicAwareness += 30;
                humanSanity -= 25;
            }
            else if (answer.Contains("заговорить"))
            {
                Console.WriteLine("\nВы спрашиваете: 'Кто ты?'");
                Console.WriteLine("Отражение отвечает: 'Я - то, кем ты станешь.'");
                Console.WriteLine("'Когда примешь правду.'");
                cosmicAwareness += 50;
                humanSanity -= 45;
            }
            
            // ШАГ 11
            Console.WriteLine("\n[11] Системы навигации показывают: станция не движется.");
            Console.WriteLine("Но и не стоит на месте. Она находится... между.");
            Console.WriteLine("Между чем и чем? Понять или игнорировать? (понять/игнорировать)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("понять"))
            {
                Console.WriteLine("\nСтанция не в пространстве. Она в мысли.");
                Console.WriteLine("Хоровод думает, и станция существует в его мысли.");
                Console.WriteLine("Вы - сон космического разума.");
                cosmicAwareness += 60;
                humanSanity -= 50;
            }
            
            // ШАГ 12
            Console.WriteLine("\n[12] Вы находите капсулу для криосна.");
            Console.WriteLine("Внутри - вы. Вы спите. Улыбаетесь во сне.");
            Console.WriteLine("Это настоящее вы? Или то, что снаружи?");
            Console.WriteLine("Разбудить спящего? (да/нет/уничтожить капсулу)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("да"))
            {
                Console.WriteLine("\nВы открываете капсулу. Тело внутри растворяется.");
                Console.WriteLine("Оно было иллюзией. Как и всё остальное.");
                Console.WriteLine("Остаётся только свет. И понимание.");
                cosmicAwareness += 70;
                humanSanity = 0;
            }
            else if (answer.Contains("уничтожить"))
            {
                Console.WriteLine("\nВы уничтожаете капсулу. Вспышка света.");
                Console.WriteLine("Боль. Потом... покой. И голос: 'Наконец-то.'");
                cosmicAwareness = 100;
                humanSanity = 0;
            }
            
            // ШАГ 13
            Console.WriteLine("\n[13] Голос снова говорит:");
            Console.WriteLine("'ТЫ ДОСТОИН. ПРИМИ ДАР. СТАНЬ ЦЕЛЬНЫМ.'");
            Console.WriteLine("Это предложение или приказ?");
            Console.WriteLine("Как ответить? (принять дар/отказаться/попросить время)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("принять") || answer.Contains("дар"))
            {
                Console.WriteLine("\nВы говорите: 'Я принимаю.'");
                Console.WriteLine("Свет заполняет всё. Боль уходит.");
                Console.WriteLine("Страх уходит. Одиночество уходит.");
                cosmicAwareness = 100;
                humanSanity = 0;
            }
            else if (answer.Contains("отказаться"))
            {
                Console.WriteLine("\nВы говорите: 'Я отказываюсь.'");
                Console.WriteLine("Тишина. Потом смех. Тысячи голосов смеются.");
                Console.WriteLine("'КАК МИЛО. КАК ПО-ЧЕЛОВЕЧЕСКИ.'");
                humanSanity -= 60;
            }
            
            // ШАГ 14
            Console.WriteLine("\n[14] Спасательная капсула цела.");
            Console.WriteLine("Автопилот может доставить вас на Землю.");
            Console.WriteLine("Но капсула говорит голосом Хоровода:");
            Console.WriteLine("'ОСТАНЬСЯ. Я НАУЧУ ТЕБЯ ЛЕТАТЬ БЕЗ КОРАБЛЯ.'");
            Console.WriteLine("Ваш выбор? (улететь/остаться/разрушить капсулу)");
            answer = Console.ReadLine().ToLower();
            
            if (answer.Contains("улететь"))
            {
                Console.WriteLine("\nВы запускаете капсулу. Станция удаляется.");
                Console.WriteLine("В последний момент она превращается в свет.");
                Console.WriteLine("Часть вас осталась там. И будет тосковать всегда.");
                humanSanity += 30;
            }
            else if (answer.Contains("остаться"))
            {
                Console.WriteLine("\nВы отказываетесь от капсулы.");
                Console.WriteLine("Стены растворяются. Пол растворяется.");
                Console.WriteLine("Остаётесь только вы. И свет. И знание.");
                cosmicAwareness = 100;
                humanSanity = 0;
            }
            
            // ШАГ 15 - ФИНАЛЬНЫЙ ВЫБОР (последний перед концовкой)
            Console.WriteLine("\n[15] Всё было подготовкой. Теперь финальный выбор:");
            Console.WriteLine("1. Стать Хороводом (принять космическое сознание)");
            Console.WriteLine("2. Остаться человеком (сохранить себя, но с памятью)");
            Console.WriteLine("3. Уничтожить станцию (прервать контакт навсегда)");
            Console.WriteLine("4. Стать мостом (остаться между мирами)");
            Console.WriteLine("Ваш выбор (1/2/3/4):");
            answer = Console.ReadLine();
            
            if (answer == "1")
            {
                cosmicAwareness = 100;
                humanSanity = 0;
                Console.WriteLine("\nВы расправляете руки. Кожа светится изнутри.");
                Console.WriteLine("Человеческое тело было тюрьмой. Теперь вы свободны.");
                Console.WriteLine("Вы становитесь частью вечного танца в пустоте.");
            }
            else if (answer == "2")
            {
                if (humanSanity < 30) humanSanity = 30;
                Console.WriteLine("\nВы закрываете глаза и повторяете своё имя.");
                Console.WriteLine("Вы вспоминаете Землю. Солнце. Дождь.");
                Console.WriteLine("Вы остаётесь собой. Но знание остаётся с вами.");
            }
            else if (answer == "3")
            {
                cosmicAwareness = 0;
                humanSanity = 100;
                Console.WriteLine("\nВы активируйте систему самоуничтожения.");
                Console.WriteLine("Вспышка. Боль. Потом темнота.");
                Console.WriteLine("Вы просыпаетесь в капсуле спасения.");
                Console.WriteLine("Всё было сном? Или...");
            }
            else if (answer == "4")
            {
                cosmicAwareness = 50;
                humanSanity = 50;
                Console.WriteLine("\nВы говорите: 'Я буду мостом.'");
                Console.WriteLine("'Я буду тем, кто понимает обе стороны.'");
                Console.WriteLine("Хоровод принимает ваш выбор.");
                Console.WriteLine("Теперь вы вечный наблюдатель.");
            }
            
            // КОНЦОВКА (16-й шаг по факту, но это уже результат)
            Console.WriteLine("\n\n=== КОНЕЦ ИСТОРИИ ===");
            Console.WriteLine($"Осознание космической истины: {cosmicAwareness}%");
            Console.WriteLine($"Связь с человечеством: {humanSanity}%");
            
            string ending = "";
            
            if (cosmicAwareness >= 80 && humanSanity <= 20)
            {
                ending = "КОНЦОВКА 1: ТАНЦОР ХОРОВОДА\nВы приняли истину. Ваше сознание расширилось\nза пределы человеческого понимания. Теперь вы\nтанцуете в вечности с теми, кто был до звезд.\nВы счастливы. Вы свободны. Вы больше не одиноки.";
            }
            else if (humanSanity >= 70 && cosmicAwareness <= 30)
            {
                ending = "КОНЦОВКА 2: ВЫЖИВШИЙ\nВы вернулись к людям. Они называют вас героем,\nно по ночам вы слышите пение в тишине.\nВы видели слишком много, но сохранили себя.\nЦена — вечное знание того, что скрывается в темноте.";
            }
            else if (cosmicAwareness >= 50 && humanSanity >= 50)
            {
                ending = "КОНЦОВКА 3: МОСТ МЕЖДУ МИРАМИ\nВы не полностью человек, но и не часть Хоровода.\nВы стали посредником. Иногда к вам приходят\nученые и спрашивают о том, что вы видели.\nВы пытаетесь объяснить необъяснимое. Это ваша миссия.";
            }
            else if (humanSanity <= 10)
            {
                ending = "КОНЦОВКА 4: РАЗРУШЕННЫЙ РАЗУМ\nВы вернулись, но не полностью. Ваше сознание\nраскололось между реальностью и Хороводом.\nВы проводите дни, рисуя фракталы на стенах,\nшепча о танце, который никогда не кончается.";
            }
            else
            {
                ending = "КОНЦОВКА 5: СТРАЖ ТАЙНЫ\nВы уничтожили станцию и все данные. Хоровод\nостался тайной. Но вы знаете — он там.\nИ он ждет. Каждую ночь вы смотрите на звезды\nи знаете, что однажды человечество встретится с ним снова.";
            }
            
            Console.WriteLine($"\n{ending}");
            
            Console.WriteLine("\nНажмите любую клавишу, чтобы завершить...");
            Console.ReadKey();
        }
    }
}