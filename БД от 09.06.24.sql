-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 09 2024 г., 22:59
-- Версия сервера: 8.0.30
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `library`
--
CREATE DATABASE IF NOT EXISTS `library` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `library`;

-- --------------------------------------------------------

--
-- Структура таблицы `authors`
--

CREATE TABLE `authors` (
  `id` int NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `authors`
--

INSERT INTO `authors` (`id`, `name`) VALUES
(1, 'Джоан Роулинг'),
(2, 'Джордж Оруэлл'),
(3, 'Лев Толстой'),
(4, 'Фёдор Достоевский'),
(5, 'Харпер Ли'),
(6, 'Дж. Р. Р. Толкин'),
(7, 'Джейн Остин'),
(8, 'Марк Твен'),
(9, 'Стивен Кинг'),
(10, 'Агата Кристи'),
(11, 'Габриэль Гарсиа Маркес'),
(12, 'Чак Паланик'),
(13, 'Михаил Булгаков'),
(14, 'Мэри Шелли'),
(15, 'Джон Стейнбек'),
(16, 'Эрнест Хемингуэй'),
(17, 'Айзек Азимов'),
(18, 'Филип К. Дик'),
(19, 'Жюль Верн'),
(20, 'Артур Конан Дойл'),
(21, 'Фрэнсис Скотт Фицджеральд'),
(22, 'Джеймс Джойс'),
(23, 'Владимир Набоков'),
(24, 'Эмили Бронте'),
(25, 'Мэгги Стайфвотер'),
(26, 'Дэн Браун'),
(27, 'Михаил Лермонтов');

-- --------------------------------------------------------

--
-- Структура таблицы `books`
--

CREATE TABLE `books` (
  `id` int NOT NULL,
  `title` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `author_id` int DEFAULT NULL,
  `genre_id` int DEFAULT NULL,
  `description` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `available` tinyint DEFAULT NULL,
  `cover_image_path` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL DEFAULT '',
  `status_id` int DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `books`
--

INSERT INTO `books` (`id`, `title`, `author_id`, `genre_id`, `description`, `available`, `cover_image_path`, `status_id`) VALUES
(1, 'Гарри Поттер и философский камень', 1, 1, 'Первая книга о Гарри Поттере, рассказывающая о том, как он узнает о своем магическом наследии и отправляется в школу волшебства Хогвартс. Здесь он находит новых друзей и сталкивается с опасными врагами.', 1, '\\Resources\\Covers\\Harry Potter and the Philosopher\'s Stone.jpg', 1),
(2, '1984', 2, 4, 'Роман о тоталитарном обществе будущего, где за людьми постоянно следят, а любое инакомыслие жестоко подавляется. Главный герой, Уинстон Смит, пытается бороться с системой и найти правду.', 1, '\\Resources\\Covers\\1984.jpg', 1),
(3, 'Война и мир', 3, 3, 'Великий роман Льва Толстого о войне, любви и судьбах нескольких семей на фоне наполеоновских войн. Произведение охватывает различные аспекты жизни в России в начале XIX века.', 1, '\\Resources\\Covers\\War and Peace.jpg', 1),
(4, 'Преступление и наказание', 4, 2, 'Роман о молодом студенте Раскольникове, который совершает убийство ради денег и оправдывает это высоким идеалом. Произведение исследует темы морали, вины и искупления.', 0, '\\Resources\\Covers\\Crime and punishment.png', 1),
(5, 'Убить пересмешника', 5, 3, 'Роман о расизме и неравенстве на американском Юге через призму детских воспоминаний. Главная героиня, девочка по имени Скаут, наблюдает за судебным процессом, в котором её отец защищает несправедливо обвиненного чернокожего мужчину.', 1, '\\Resources\\Covers\\To Kill a Mockingbird.jpg', 1),
(6, 'Властелин колец', 6, 1, 'Эпическая фэнтези-сага Дж. Р. Р. Толкина, рассказывающая о борьбе за уничтожение могущественного Кольца Всевластья. Друзья и союзники сражаются с темными силами, чтобы спасти Средиземье.', 1, '\\Resources\\Covers\\Lord of the Rings.jpg', 1),
(7, 'Гордость и предубеждение', 7, 3, 'Роман Джейн Остин о любви и общественных предрассудках. История Элизабет Беннет и мистера Дарси раскрывает сложные отношения и социальные нормы Англии конца XVIII века.', 1, '\\Resources\\Covers\\Pride and prejudice.jpg', 1),
(8, 'Приключения Тома Сойера', 8, 6, 'Приключенческий роман Марка Твена о мальчике Томе Сойере и его друзьях. История полна веселья, опасных ситуаций и исследует тему детства на реке Миссисипи.', 1, '\\Resources\\Covers\\The Adventures of Tom Sawyer.jpg', 1),
(9, 'Оно', 9, 7, 'Роман Стивена Кинга о злом существе, которое пугает детей в Дерри, штат Мэн. Группа друзей сталкивается со своими самыми страшными кошмарами, чтобы остановить его.', 0, '\\Resources\\Covers\\It.jpg', 1),
(10, 'Убийства по алфавиту', 10, 2, 'Детектив Агаты Кристи, в котором Эркюль Пуаро расследует серию убийств, происходящих в городах по алфавиту. Каждое преступление связано с буквой алфавита.', 1, '\\Resources\\Covers\\Alphabetical murders.jpg', 1),
(11, 'Сто лет одиночества', 11, 3, 'Эпическая сага Габриэля Гарсиа Маркеса о семье Буэндиа и их судьбах в вымышленном городке Макондо. Роман исследует темы времени, судьбы и магического реализма.', 1, '\\Resources\\Covers\\Сто лет одиночества.png', 1),
(12, 'Бойцовский клуб', 12, 10, 'Роман Чака Паланика о подпольном клубе, где мужчины дерутся, чтобы выразить свои эмоции и найти смысл в жизни. История исследует темы насилия, потребительства и самоидентификации.', 1, '\\Resources\\Covers\\Бойцовский клуб.png', 1),
(13, 'Мастер и Маргарита', 13, 4, 'История Михаила Булгакова о дьяволе, посетившем Москву, и его приключениях. Роман сочетает элементы фантастики, сатиры и философии, переплетая судьбы различных персонажей.', 1, '\\Resources\\Covers\\Мастер и Маргарита.jpg', 1),
(14, 'Франкенштейн', 14, 11, 'Классический готический роман Мэри Шелли о создании монстра Виктором Франкенштейном. Произведение исследует темы морали, ответственности и человеческой природы.', 1, '\\Resources\\Covers\\Франкенштейн.jpg', 1),
(15, 'Гроздья гнева', 15, 3, 'Роман Джона Стейнбека о семье Джоуд, страдающей во времена Великой депрессии. История рассказывает о миграции и борьбе за выживание в условиях экономических трудностей.', 1, '\\Resources\\Covers\\Гроздья гнева.jpg', 1),
(16, 'Старик и море', 16, 3, 'История Эрнеста Хемингуэя о старом рыбаке, который сражается с гигантской рыбой в море. Роман исследует темы мужества, стойкости и человеческой борьбы.', 1, '\\Resources\\Covers\\Старик и море.jpg', 1),
(17, 'Я, робот', 17, 4, 'Сборник рассказов Айзека Азимова о роботах и законах робототехники. Произведение исследует взаимодействие людей и машин в будущем.', 1, '\\Resources\\Covers\\Я, робот.jpg', 1),
(18, 'Мечтают ли андроиды об электроовцах?', 18, 4, 'Роман Филипа Дика, вдохновивший фильм \"Бегущий по лезвию\". История о мире, где андроиды становятся неотличимыми от людей, и о том, что делает человека человеком.', 1, '\\Resources\\Covers\\Мечтают ли андроиды об электроовцах.jpg', 1),
(19, 'Двадцать тысяч лье под водой', 19, 6, 'Приключенческий роман Жюля Верна о подводных путешествиях капитана Немо на корабле \"Наутилус\". История полна научных открытий и опасных приключений.', 1, '\\Resources\\Covers\\Двадцать тысяч лье под водой.png', 1),
(20, 'Приключения Шерлока Холмса', 20, 2, 'Сборник детективных историй Артура Конан Дойля о великом сыщике Шерлоке Холмсе и его верном друге докторе Ватсоне. Каждый рассказ представляет собой уникальную загадку.', 1, '\\Resources\\Covers\\Приключения Шерлока Холмса.jpg', 1),
(21, 'Великий Гэтсби', 21, 3, 'История Ф. Скотта Фицджеральда о богатстве, любви и трагедии в Америке 1920-х годов. Роман раскрывает иллюзорность американской мечты и сложность человеческих отношений.', 1, '\\Resources\\Covers\\Великий Гэтсби.jpg', 1),
(22, 'Улисс', 22, 3, 'Экспериментальный роман Джеймса Джойса, описывающий один день из жизни жителей Дублина. Произведение сочетает сложные литературные техники и глубинный анализ человеческого сознания.', 1, '\\Resources\\Covers\\Улисс.jpg', 1),
(23, 'Лолита', 23, 9, 'Психологический роман Владимира Набокова о любви взрослого мужчины к девочке. Произведение исследует темы морали, желания и социальной табу.', 1, '\\Resources\\Covers\\Лолита.jpg', 1),
(24, 'Грозовой перевал', 24, 11, 'Готический роман Эмили Бронте о страстной и разрушительной любви между Хитклифом и Кэтрин. История полна трагедии, мести и эмоциональных бурь.', 1, '\\Resources\\Covers\\Грозовой перевал.jpg', 1),
(25, 'Воронята', 25, 11, 'Роман о молодой девушке, которая может видеть будущее. История исследует взаимодействие человека с его сверхъестественными способностями и окружающим миром.', 1, '\\Resources\\Covers\\Воронята.jpg', 1),
(26, 'Код да Винчи', 26, 2, 'Детективный триллер Дэна Брауна о разгадке тайны, связанной с Иисусом Христом. Произведение сочетает элементы мистики, истории и головоломок.', 1, '\\Resources\\Covers\\Код да Винчи.png', 1),
(27, 'gfgfdgfdgdfsgsdf', 23, 3, 'Привет как \nдела\n?', 1, '', 1),
(29, 'Привет', 22, 4, 'ыфвфывфывфы', 1, '\\Resources\\Covers\\Привет.jpg', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `genres`
--

CREATE TABLE `genres` (
  `id` int NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `genres`
--

INSERT INTO `genres` (`id`, `name`) VALUES
(1, 'Фэнтези'),
(2, 'Детектив'),
(3, 'Классика'),
(4, 'Научная фантастика'),
(5, 'Роман'),
(6, 'Приключения'),
(7, 'Ужасы'),
(8, 'Юмор'),
(9, 'Исторический роман'),
(10, 'Триллер'),
(11, 'Реализм'),
(12, 'Готический роман'),
(13, 'Современная проза'),
(14, 'Мистика'),
(15, 'Психологический триллер'),
(16, 'Биография'),
(17, 'Юмористический роман'),
(18, 'Комедия'),
(19, 'Эпопея'),
(20, 'Антиутопия'),
(21, 'Постапокалипсис'),
(22, 'Поэзия'),
(23, 'Драма'),
(24, 'Эссеистика'),
(25, 'Документальная проза');

-- --------------------------------------------------------

--
-- Структура таблицы `rentals`
--

CREATE TABLE `rentals` (
  `id` int NOT NULL,
  `user_id` int DEFAULT NULL,
  `book_id` int DEFAULT NULL,
  `rental_date` datetime DEFAULT NULL,
  `return_date` datetime DEFAULT NULL,
  `reservation_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `rentals`
--

INSERT INTO `rentals` (`id`, `user_id`, `book_id`, `rental_date`, `return_date`, `reservation_id`) VALUES
(2, 2, 5, '2024-05-03 12:00:00', '2024-05-10 12:00:00', 3),
(3, 3, 7, '2024-05-07 15:00:00', NULL, NULL),
(4, 1, 3, '2024-05-10 16:00:00', '2024-06-06 18:57:53', 5),
(5, 4, 4, '2024-05-09 17:00:00', NULL, NULL),
(6, 49, 3, '2024-06-06 14:45:54', '2024-06-06 18:15:59', 27),
(7, 1, 1, '2024-06-06 14:52:04', '2024-06-06 18:57:55', 26),
(8, 45, 3, '2024-06-06 15:01:43', NULL, 17),
(9, 1, 15, '2024-06-06 18:57:03', '2024-06-06 18:57:49', 28),
(10, 1, 25, '2024-06-06 19:05:38', '2024-06-06 19:06:15', 29),
(11, 1, 12, '2024-06-07 11:43:54', '2024-06-07 11:44:33', 30);

-- --------------------------------------------------------

--
-- Структура таблицы `reservations`
--

CREATE TABLE `reservations` (
  `id` int NOT NULL,
  `user_id` int DEFAULT NULL,
  `book_id` int DEFAULT NULL,
  `reservation_code` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `reservation_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `rented` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `reservations`
--

INSERT INTO `reservations` (`id`, `user_id`, `book_id`, `reservation_code`, `reservation_date`, `rented`) VALUES
(2, 3, 4, '12354', '2024-05-02 11:00:00', 0),
(3, 2, 5, '97642', '2024-05-03 12:00:00', 1),
(4, 4, 1, '87612', '2024-05-04 13:00:00', 0),
(5, 5, 3, '67657', '2024-05-05 14:00:00', 1),
(17, 45, 3, '33333', '2024-06-03 15:16:24', 1),
(21, 1, 7, '63412', '2024-06-03 17:31:51', 1),
(22, 1, 20, '52782', '2024-06-03 17:35:51', 1),
(26, 1, 1, '22222', '2024-06-04 14:53:46', 1),
(27, 49, 3, '11111', '2024-06-04 15:32:53', 1),
(28, 1, 15, '29394', '2024-06-06 17:56:21', 1),
(29, 1, 25, '59833', '2024-06-06 18:05:19', 1),
(30, 1, 12, '55872', '2024-06-06 19:08:44', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `roles`
--

CREATE TABLE `roles` (
  `id` int NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `roles`
--

INSERT INTO `roles` (`id`, `name`) VALUES
(1, 'Администратор'),
(2, 'Библиотекарь'),
(3, 'Читатель');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `login` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `email` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `role_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `name`, `login`, `password`, `email`, `role_id`) VALUES
(1, 'Иванов Трофим Сергеевич', 'us', 'C4CA4238A0B923820DCC509A6F75849B', 'marychev5@ya.ru', 3),
(2, 'Петрова Ксения Семеновна', 'adm', 'C4CA4238A0B923820DCC509A6F75849B', 'marycheff17@gmail.com', 1),
(3, 'Сидоров Андрей Сергеевич', 'andsid23', '7110EDA4D09E062AA5E4A390B0A572AC', 'sid.and@example.com', 1),
(4, 'Петрова Елена Николаевна', 'elenanik', 'A152E841783914146E4BCD4F39100686', 'petrova.elena@example.com', 1),
(5, 'Смирнов Дмитрий Иванович', 'smirdmitr', '4C84F3A74189526FE4938D2799BC1E7F', 'smir.d@example.com', 1),
(6, 'Козлова Анастасия Олеговна', 'k_ana', 'E99A18C428CB38D5F260853678922E03', 'ana.kozlova@example.com', 2),
(7, 'Новиков Игорь Павлович', 'igor45', '2F5BCCF03197E48E84CDA6F1499F50CD', 'novikov.igor@example.com', 2),
(8, 'Васильева Мария Александровна', 'mashka', '292C5BA9B2C9D9B16C55E2EC48A02AA8', 'masha.vas@example.com', 3),
(9, 'Кузнецов Владимир Викторович', 'kuznvlad', '361D0E80A64D70D21CBE0C23B5502B98', 'kuznetsov.vlad@example.com', 3),
(10, 'Морозова Ольга Дмитриевна', 'olgad', '4A1D4DBC1E193EC3AB2E9213876CEB8F', 'olga.morozova@example.com', 3),
(11, 'Алексеев Илья Степанович', 'alex_st', '7C4A8D09CA3762AF61E59520943DC264', 'alex.il@example.com', 3),
(12, 'Кузьмина Анна Ивановна', 'annakuz', '095F32C383E52D334F8E16B7F9F849C4', 'kuzmina.anna@example.com', 3),
(13, 'Соколова Екатерина Валерьевна', 'kat_sok', '0CBC6611F5540BD0809A388DC95A615B', 'sokolova.kat@example.com', 3),
(14, 'Павлов Павел Владимирович', 'pavlov_p', '0CB9E51CCCD99C73666DB9C756F2B5E8', 'pavel.pavlov@example.com', 3),
(15, 'Федорова Татьяна Александровна', 'tatfed', '1A665849B3A312E9F85C38099B6F7584', 'tanya.fed@example.com', 3),
(16, 'Ковалев Александр Петрович', 'koval', '04E38FC6A57E23837B553CB6515F3BD3', 'koval.alex@example.com', 3),
(17, 'Макарова Анастасия Васильевна', 'nastya_m', 'D4735E3A265E16EEE03F59718B9B5D030', 'anastasia.mak@example.com', 3),
(18, 'Семенов Сергей Игоревич', 's_serg', '27B2F68D86CEEB196D4A77F9D67F4291', 'semenov.serg@example.com', 3),
(19, 'Иванов Иван Иванович', 'ivaniv', '8D1A8F35F41772C0C9AD52DC8E4EF0D4', 'ivanov.ivan@example.com', 3),
(20, 'Петров Петр Петрович', 'ppp', 'F87B41EA1948B7E010A90FF43F837171', 'petr.petrov@example.com', 3),
(21, 'Сидоров Сидор Сидорович', 'sid_sid', '15BF7A427A55E2B798D7AD8B46568F05', 'sidorov.sidor@example.com', 3),
(22, 'Андреев Андрей Андреевич', 'and_andr', 'A10498067F41F051D89F014C0AE1FC4E', 'andreev.andrey@example.com', 3),
(23, 'Николаев Николай Николаевич', 'nik_nik', '2FD4E1C67A2D28FCED849EE1BB76E739', 'nikolay.nik@example.com', 3),
(24, 'Михайлов Михаил Михайлович', 'mih_mih', '5859D9A5F03E7A5BB7D8D9770CF1656A', 'mikhailov.mihail@example.com', 3),
(25, 'Юдин Юрий Юрьевич', 'yur_yud', '85F0A2DB0AD9E7CDCB323B4BD1674D38', 'yudin.yuri@example.com', 3),
(26, 'Романов Роман Романович', 'roma_rom', 'EC9F7EE40C09E94E68335BC3299A194E', 'romanov.roman@example.com', 3),
(27, 'Тимофеев Тимофей Тимофеевич', 'tim_tim', '74B87337454200D4D33F80C4663DC5E5', 'timofeev.tim@example.com', 3),
(28, 'Кузьмин Кузьма Кузьминич', 'kuz_kuz', '5BFA9D279D0C830E8D0CA33D178FC11F', 'kuzmin.kuzma@example.com', 3),
(29, 'Козлов Козьма Козлович', 'koz_koz', '352B3F3E60E3E8694582F6B1F5BA5400', 'kozlov.kozma@example.com', 3),
(30, 'Лебедев Лебедь Лебедевич', 'leb_leb', '22BFC4044D209586D4D6DCDECC23612A', 'lebedev.leb@example.com', 3),
(31, 'Артемьев Артем Артемьевич', 'art_art', '7F631264FA40E46F861B7A9FBDD2D50E', 'artemev.artem@example.com', 3),
(32, 'Владимиров Владимир Владимирович', 'vlad_vlad', 'FA75ECEC5763E793AC0DBBDD3B6D5972', 'vladimirov.vladimir@example.com', 3),
(33, 'Александров Александр Александрович', 'alex_alex', 'F1FB814C624F05E7E4E9B81C0CE4248F', 'aleksandrov.alex@example.com', 3),
(34, 'Степанов Степан Степанович', 'step_step', '204DA0DB02B47F7262E9A7F3E83D4E82', 'stepanov.stepan@example.com', 3),
(35, 'Никитин Никита Никитич', 'nik_nik', 'FE9FC289C3FF0AF142B6D3BEAD98A923', 'nikitin.nikita@example.com', 3),
(36, 'Сергеев Сергей Сергеевич', 'serg_serg', '27B2F68D86CEEB196D4A77F9D67F4291', 'sergeev.sergei@example.com', 3),
(37, 'Максимов Максим Максимович', 'max_max', 'F2E08B8E6364F3F5027A079379F4A7D8', 'maximov.maxim@example.com', 3),
(38, 'Павловский Павел Павлович', 'pav_pav', '4FC580C8F7211FE6D9E180BCF46B57C1', 'pavlovsky.pavel@example.com', 3),
(39, 'Дмитриев Дмитрий Дмитриевич', 'dmit_dmit', '2D6A5440B57DA607B94CBE8EDD7EA850', 'dmitriev.dmitry@example.com', 3),
(40, 'Юрьев Юрий Юрьевич', 'yur_yur', 'B429124DC26427077DB8EA94F7A526E7', 'yurev.yuri@example.com', 3),
(41, 'Иванов Иван Иванович', 'ivan_ivan', '35A7C377DAA8E26B19B0C45C3DEA34CB', 'ivanov.ivan@example.com', 3),
(42, 'Семенов Семен Семенович', 'sem_sem', '135792468DB48F610EB52E57F0D0A229', 'semenov.semen@example.com', 3),
(43, 'Андреев Андрей Андреевич', 'and_andr', 'FBA0C23456D8592DD43A8F7C5C11D5C2', 'andreev.andrey@example.com', 3),
(44, 'Иванов Иван Иванович', 'dasdjashdjklasjhk', 'C4CA4238A0B923820DCC509A6F75849B', 'dsadasdas@asdsa.cas', 3),
(45, 'sadsa dsadas eqw', 'dasdasdaeqwewq', 'C4CA4238A0B923820DCC509A6F75849B', 'dasdasd', 3),
(49, 'Марычев Максим fdfsd', 'marycheff', 'C4CA4238A0B923820DCC509A6F75849B', 'marychev2228@gmail.com', 3);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`),
  ADD KEY `author_id` (`author_id`),
  ADD KEY `genre_id` (`genre_id`),
  ADD KEY `status_id` (`status_id`);

--
-- Индексы таблицы `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `rentals`
--
ALTER TABLE `rentals`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `book_id` (`book_id`),
  ADD KEY `reservation_id` (`reservation_id`);

--
-- Индексы таблицы `reservations`
--
ALTER TABLE `reservations`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `book_id` (`book_id`);

--
-- Индексы таблицы `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role_id` (`role_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `authors`
--
ALTER TABLE `authors`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT для таблицы `books`
--
ALTER TABLE `books`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT для таблицы `genres`
--
ALTER TABLE `genres`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT для таблицы `rentals`
--
ALTER TABLE `rentals`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `reservations`
--
ALTER TABLE `reservations`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT для таблицы `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`author_id`) REFERENCES `authors` (`id`),
  ADD CONSTRAINT `books_ibfk_2` FOREIGN KEY (`genre_id`) REFERENCES `genres` (`id`);

--
-- Ограничения внешнего ключа таблицы `rentals`
--
ALTER TABLE `rentals`
  ADD CONSTRAINT `rentals_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `rentals_ibfk_2` FOREIGN KEY (`book_id`) REFERENCES `books` (`id`),
  ADD CONSTRAINT `rentals_ibfk_3` FOREIGN KEY (`reservation_id`) REFERENCES `reservations` (`id`);

--
-- Ограничения внешнего ключа таблицы `reservations`
--
ALTER TABLE `reservations`
  ADD CONSTRAINT `reservations_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `reservations_ibfk_2` FOREIGN KEY (`book_id`) REFERENCES `books` (`id`);

--
-- Ограничения внешнего ключа таблицы `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
