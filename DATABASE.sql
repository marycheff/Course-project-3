BEGIN;
CREATE TABLE IF NOT EXISTS roles (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) UNIQUE
);
CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255),
    login VARCHAR(255),
    password VARCHAR(255),
    email VARCHAR(255),
    role_id INT,
    FOREIGN KEY(role_id) REFERENCES roles(id)
);
INSERT INTO roles (name) VALUES ('Администратор'), ('Библиотекарь'), ('Читатель');
INSERT INTO user (name, login, password, email, role_id) 
VALUES 
    ('Сидоров Андрей Сергеевич', 'andsid23', 'klop0987', 'sid.and@example.com', 1), 
    ('Петрова Елена Николаевна', 'elenanik', 'qwerty123', 'petrova.elena@example.com', 1), 
    ('Смирнов Дмитрий Иванович', 'smirdmitr', 'dima321', 'smir.d@example.com', 1), 
    ('Козлова Анастасия Олеговна', 'k_ana', 'ana456', 'ana.kozlova@example.com', 2), 
    ('Новиков Игорь Павлович', 'igor45', 'novikov123', 'novikov.igor@example.com', 2), 
    ('Васильева Мария Александровна', 'mashka', 'maria789', 'masha.vas@example.com', 3),
    ('Кузнецов Владимир Викторович', 'kuznvlad', 'vlad555', 'kuznetsov.vlad@example.com', 3),
    ('Морозова Ольга Дмитриевна', 'olgad', 'dol999', 'olga.morozova@example.com', 3),
    ('Алексеев Илья Степанович', 'alex_st', 'alex123', 'alex.il@example.com', 3), 
    ('Кузьмина Анна Ивановна', 'annakuz', 'anna777', 'kuzmina.anna@example.com', 3),
    ('Соколова Екатерина Валерьевна', 'kat_sok', 'kat123', 'sokolova.kat@example.com', 3),
    ('Павлов Павел Владимирович', 'pavlov_p', 'pav456', 'pavel.pavlov@example.com', 3),
    ('Федорова Татьяна Александровна', 'tatfed', 'fed987', 'tanya.fed@example.com', 3),
    ('Ковалев Александр Петрович', 'koval', 'alex890', 'koval.alex@example.com', 3),
    ('Макарова Анастасия Васильевна', 'nastya_m', 'nasty123', 'anastasia.mak@example.com', 3),
    ('Семенов Сергей Игоревич', 's_serg', 'serg456', 'semenov.serg@example.com', 3),
    ('Иванов Иван Иванович', 'ivaniv', 'ivan456', 'ivanov.ivan@example.com', 3),
    ('Петров Петр Петрович', 'ppp', 'ppp123', 'petr.petrov@example.com', 3),
    ('Сидоров Сидор Сидорович', 'sid_sid', 'sidor123', 'sidorov.sidor@example.com', 3),
    ('Андреев Андрей Андреевич', 'and_andr', 'and456', 'andreev.andrey@example.com', 3),
    ('Николаев Николай Николаевич', 'nik_nik', 'nik123', 'nikolay.nik@example.com', 3),
    ('Михайлов Михаил Михайлович', 'mih_mih', 'mih789', 'mikhailov.mihail@example.com', 3),
    ('Юдин Юрий Юрьевич', 'yur_yud', 'yur456', 'yudin.yuri@example.com', 3),
    ('Романов Роман Романович', 'roma_rom', 'roma123', 'romanov.roman@example.com', 3),
    ('Тимофеев Тимофей Тимофеевич', 'tim_tim', 'tim999', 'timofeev.tim@example.com', 3),
    ('Кузьмин Кузьма Кузьминич', 'kuz_kuz', 'kuz456', 'kuzmin.kuzma@example.com', 3),
    ('Козлов Козьма Козлович', 'koz_koz', 'koz789', 'kozlov.kozma@example.com', 3),
    ('Лебедев Лебедь Лебедевич', 'leb_leb', 'leb123', 'lebedev.leb@example.com', 3),
    ('Артемьев Артем Артемьевич', 'art_art', 'art555', 'artemev.artem@example.com', 3),
    ('Владимиров Владимир Владимирович', 'vlad_vlad', 'vlad123', 'vladimirov.vladimir@example.com', 3),
    ('Александров Александр Александрович', 'alex_alex', 'alex890', 'aleksandrov.alex@example.com', 3),
    ('Степанов Степан Степанович', 'step_step', 'step123', 'stepanov.stepan@example.com', 3),
    ('Никитин Никита Никитич', 'nik_nik', 'nik999', 'nikitin.nikita@example.com', 3),
    ('Сергеев Сергей Сергеевич', 'serg_serg', 'serg123', 'sergeev.sergei@example.com', 3),
    ('Максимов Максим Максимович', 'max_max', 'max456', 'maximov.maxim@example.com', 3),
    ('Павловский Павел Павлович', 'pav_pav', 'pav789', 'pavlovsky.pavel@example.com', 3),
    ('Дмитриев Дмитрий Дмитриевич', 'dmit_dmit', 'dmit123', 'dmitriev.dmitry@example.com', 3),
    ('Юрьев Юрий Юрьевич', 'yur_yur', 'yur789', 'yurev.yuri@example.com', 3),
    ('Иванов Иван Иванович', 'ivan_ivan', 'ivan987', 'ivanov.ivan@example.com', 3),
    ('Семенов Семен Семенович', 'sem_sem', 'sem456', 'semenov.semen@example.com', 3),
    ('Андреев Андрей Андреевич', 'and_andr', 'and987', 'andreev.andrey@example.com', 3);
COMMIT;
