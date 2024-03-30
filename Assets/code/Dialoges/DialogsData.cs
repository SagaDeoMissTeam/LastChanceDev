using System.Collections.Generic;
using JetBrains.Annotations;

namespace code.Dialoges
{
    public class DialogsData
    {

        public static Dialog getDialog1()
        {
            Dialog dialog = new Dialog("Даниэль", "Ха… И где я?....??? Что это?");
            dialog.addParent(new Dialog("?",
                    "Здравствуй путник, я понимаю, ты удивлён, но не стоит переживать, ведь тебе выпал прекрасный шанс!"))
                .addParent(new Dialog("Даниэль", "Какой ещё… Шанс?"))
                .addParent(new Dialog("?",
                    "Если ты хочешь вернуться к своей обычной жизни, тебе необходимо пройти МОЮ игру…. Тебе нужно пройти всего несколько заданий, удачи"));
            return dialog;
        }        
        public static Dialog getDialog2()
        {
            Dialog dialog = new Dialog("Даниэль", "Ха… И где я?....??? Что это?");
            dialog.addParent(new Dialog("Богдич",
                    "Здравствуйте, меня зовут Богдич, я ваш персональный помощник в этом мире. Благодаря мне вы сможете с лёгкостью выбраться из данного мира."))
                .addParent(new Dialog("Даниэль", "Агааа… Ну… Чем ты можешь помочь?"))
                .addParent(new Dialog("Богдич",
                    "Прошу вас ознакомиться с управлением, так вам будет проще выжить."))
                .addParent(new Dialog("Даниэль", "Ага, понял, спасибо, а что ещё?"))
                .addParent(new Dialog("Богдич",
                    "А что ещё, вы узнаете чуть позже, потому что пока вам большее знать не обязательно, так не интересно."))
                .addParent(new Dialog("Даниэль",
                    "Супер.. Ну ладно, тогда ты идёшь со мной… Или… Передвигаешься... Висишь?.. Ай, забей короче…."))
                .addParent(new Dialog("Богдич", "С удовольствием."));
            return dialog;
        }

        public static Dialog getDialog3()
        {
            Dialog dialog = new Dialog("Даниэль", "Эм, извините, я могу вам помочь");
            dialog.addParent(new Dialog("Лесник",
                    "А!? Кто здесь?!....."))
                .addParent(new Dialog("Лесник", "А, это просто человек… Ха… А я уж думал хочмики…."))
                .addParent(new Dialog("Даниэль",
                    "Хочмики?"))
                .addParent(new Dialog("Богдич",
                    "Хочмики – это мелкие существа вредители этой вселенной, благодаря ним у многих жителей этого мира есть проблемы, но данные мобы крайне слабы и из них могут выпадать ценные ресурсы для вас."))
                .addParent(new Dialog("Даниэль",
                    "А, вот оно как… Ну.. Что ж, так вам нужна помощь?"))
                .addParent(new Dialog("Лесник",
                    "Нифига… Оно говорит… А? А! Да… Я… Я потерялся…."))
                .addParent(new Dialog("Даниэль", "Потерялись?"))
                .addParent(new Dialog("Лесник",
                    "Да, я сам не местный, вышел вот из леса, думал тут в пруду в парке порыбачить и вот…"))
                .addParent(new Dialog("Даниэль",
                    "Ага… Вот как… Ну, давайте я помогу вам найти этот парк.\nЛесник: - Правда! О, хвала корнишонам, спасибо добрый парнишка, буду крайне признателен!"))
                .addParent(new Dialog("Богдич", "Парк находится прямо по улице, не потеряетесь."))
                .addParent(new Dialog("Даниэль", "Спасибо, Бодь."))
                .addParent(new Dialog("Богдич", "…"));
            return dialog;
        }

        public static Dialog getDialog4()
        {
            Dialog dialog = new Dialog("Даниэль", "Это оно?");
            dialog
                .addParent(new Dialog("Лесник", "Да! ДА! Это то самое место, ох, спасибо тебе добрый мальчик, без тебя бы я совсем тут заплутал и остался на съедение хочмикам… Я… Вот, держи, в знак благодарности."))
                .addParent(new Dialog("Богдич", "О, это «Стальное дробило» - данное оружие использовали ещё во времена игр, когда ты ещё на свет не появился, ХА ХА, но в данной игре оно нааааамного круче, оно нам точно понадобиться."))
                .addParent(new Dialog("Даниэль", "Спасибо Лесник, и тебе Бодь."))
                .addParent(new Dialog("Богдич", "… Хватит."));
            return dialog;
        }        
        
        public static Dialog getDialog5()
        {
            Dialog dialog = new Dialog("Аннет", "КТО ПОСМЕЛ ВОЙТИ В МОЮ ПЕЩЕРУ БЕЗ РАЗРЕШЕНИЯ, ДА ЕЩЁ И В ПЕРИОД ДЕДЛАЙНА?!");
            dialog
                .addParent(new Dialog("Богдич",
                    "Оу, ты кажется попал, это Аннет – 1 из боссов, с которым тебе нужно сразится, дабы получить шанс на выход, сейчас она завалина работай, а тут плохой интернет, так что… Сейчас она расположена только на драку."))
                .addParent(new Dialog("Даниэль", "Понял."));
            return dialog;
        }        
        
        public static Dialog getDialog6()
        {
            Dialog dialog = new Dialog("Аннет", "Стой стой! Прошу, перестань, ты мне сейчас последний ноготь отломаешь!");
            dialog
                .addParent(new Dialog("Аннет", "Ладно, что ты хочешь?"))
                .addParent(new Dialog("Аннет", "Я сделаю всё что пожелаешь, только не бей…"))
                .addParent(new Dialog("Даниэль", "Мне нужна помощь и ты мне скажешь как попасть в настоящий мир."))
                .addParent(new Dialog("Аннет", "Настоящий?"))
                .addParent(new Dialog("Аннет", "Аааа, это из которого меня Нектос выгнал…"))
                .addParent(new Dialog("Аннет", "Ха…"))
                .addParent(new Dialog("Аннет",
                    "Чтобы попасть в него, тебе нужно пойти к магу Артрус, он в мире мистики, он просто откроет тебе портал и ты вернёшься домой."))
                .addParent(new Dialog("Даниэль", "И всё? Так просто? А… Как мне попасть в тот мир?"))
                .addParent(new Dialog("Аннет",
                    "Я просто открою тебе портал, а дальше как-нибудь сам, но главное помни: НЕ СМЕЙ ТРОГАТЬ ЕГО ВЕЩИ!"))
                .addParent(new Dialog("Богдич", "Я запомнил."))
                .addParent(new Dialog("Даниэль", "Понял."))
                .addParent(new Dialog("Аннет", "Тогда ступай…"));
            return dialog;
        }        
        
        public static Dialog getDialog7()
        {
            Dialog dialog = new Dialog("Даниэль", "Думаешь он не заметит?...");
            dialog
                .addParent(new Dialog("Богдич", "Вероятность не получения по бошке составляет 14%"))
                .addParent(new Dialog("Даниэль", "Мало…"))
                .addParent(new Dialog("Артрус", "?... Кто пожаловал ко мне в такой час? Я не ожидал гос…. "))
                .addParent(new Dialog("Артрус", "Чем… Чем это пахнет?"))
                .addParent(new Dialog("Артрус", "!!!!"))
                .addParent(new Dialog("Артрус", "Неужели…"))
                .addParent(new Dialog("Артрус", "НИУЖЕЛИ ВЫ РАЗБИЛИ МОЙ ПОСЛЕДНИЙ ФЛАКОН С ФЕРОМОНАМИ!?"))
                .addParent(new Dialog("Богдич", "О оу…"))
                .addParent(
                    new Dialog("Артрус", "ДА ТЫ ХОТЬ ЗНАЕШЬ КАК ТРУДНО ДОСТАТЬ ЕГО В НАШЕ ВРЕМЯ!? Я… Я ПРОСТО… "))
                .addParent(new Dialog("Артрус", "Я просто выбью из тебя этот жалкий феромон…"));
            return dialog;
        }     
        
        public static Dialog getDialog8()
        {
            Dialog dialog = new Dialog("Даниэль", "Ну… Это было не так уж и сложно");
            dialog
                .addParent(new Dialog("Даниэль", "!? Что происходит!?"))
                .addParent(new Dialog("Даниэль", "Ха?... Где это я?"))
                .addParent(new Dialog("?", "ТЫ! Да как ты смеешь ломать все каноны моего мира!?"))
                .addParent(new Dialog("?",
                    "Ты должен был просто помочь магу найти хочмиков для его нового зелья и он бы помог тебе вернуться обратно, но нееееет, гг же самый умный, всё знает лучше… "))
                .addParent(new Dialog("?", "А знаешь что?"))
                .addParent(new Dialog("Эндикс", "А я тебя убью…"))
                .addParent(new Dialog("Эндикс",
                    "Как бог Эндикс, видя, как ты любишь портить чужое, так я испорчу и твоё…"))
                .addParent(new Dialog("Богдич",
                    "Пс… Я тут пока он болтал улучшил тебе оружие, я больше ничем помочь не могу, но там удачи."))
                .addParent(new Dialog("Даниэль", "Спасибо, Бодь… Ну что ж, пора с этим покончить…"));
            return dialog;
        }        
        public static Dialog getDialog9()
        {
            Dialog dialog = new Dialog("Эндикс", "НЕТ! НЕЕЕЕЕЕЕЕЕТ!");
            dialog
                .addParent(new Dialog("Даниэль", "???"))
                .addParent(new Dialog("Даниэль", "Где я?... А… Моя комната?..."))
                .addParent(new Dialog("Даниэль", "Ааааа, это всё…"))
                .addParent(new Dialog("Даниэль", "Ну хорошо"));
            return dialog;
        }
    }
}