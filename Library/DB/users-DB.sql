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

-- Добавление ролей
INSERT INTO roles (name) VALUES ('Администратор'), ('Библиотекарь'), ('Читатель');

-- Добавление пользователей с хэшированными паролями
INSERT INTO users (name, login, password, email, role_id) 
VALUES 
    ('Иванов Трофим Сергеевич', 'us', 'C4CA4238A0B923820DCC509A6F75849B', 'marycheff17@gmail.com', 3), -- 1
    ('Петрова Ксения Семеновна', 'adm', 'C4CA4238A0B923820DCC509A6F75849B', 'marycheff17@gmail.com', 1), -- 1
    ('Сидоров Андрей Сергеевич', 'andsid23', '7110EDA4D09E062AA5E4A390B0A572AC', 'sid.and@example.com', 1), -- klop0987
    ('Петрова Елена Николаевна', 'elenanik', 'A152E841783914146E4BCD4F39100686', 'petrova.elena@example.com', 1), -- qwerty123
    ('Смирнов Дмитрий Иванович', 'smirdmitr', '4C84F3A74189526FE4938D2799BC1E7F', 'smir.d@example.com', 1), -- dima321
    ('Козлова Анастасия Олеговна', 'k_ana', 'E99A18C428CB38D5F260853678922E03', 'ana.kozlova@example.com', 2), -- ana456
    ('Новиков Игорь Павлович', 'igor45', '2F5BCCF03197E48E84CDA6F1499F50CD', 'novikov.igor@example.com', 2), -- novikov123
    ('Васильева Мария Александровна', 'mashka', '292C5BA9B2C9D9B16C55E2EC48A02AA8', 'masha.vas@example.com', 3), -- maria789
    ('Кузнецов Владимир Викторович', 'kuznvlad', '361D0E80A64D70D21CBE0C23B5502B98', 'kuznetsov.vlad@example.com', 3), -- vlad555
    ('Морозова Ольга Дмитриевна', 'olgad', '4A1D4DBC1E193EC3AB2E9213876CEB8F', 'olga.morozova@example.com', 3), -- dol999
    ('Алексеев Илья Степанович', 'alex_st', '7C4A8D09CA3762AF61E59520943DC264', 'alex.il@example.com', 3), -- alex123
    ('Кузьмина Анна Ивановна', 'annakuz', '095F32C383E52D334F8E16B7F9F849C4', 'kuzmina.anna@example.com', 3), -- anna777
    ('Соколова Екатерина Валерьевна', 'kat_sok', '0CBC6611F5540BD0809A388DC95A615B', 'sokolova.kat@example.com', 3), -- kat123
    ('Павлов Павел Владимирович', 'pavlov_p', '0CB9E51CCCD99C73666DB9C756F2B5E8', 'pavel.pavlov@example.com', 3), -- pav456
    ('Федорова Татьяна Александровна', 'tatfed', '1A665849B3A312E9F85C38099B6F7584', 'tanya.fed@example.com', 3), -- fed987
    ('Ковалев Александр Петрович', 'koval', '04E38FC6A57E23837B553CB6515F3BD3', 'koval.alex@example.com', 3), -- alex890
    ('Макарова Анастасия Васильевна', 'nastya_m', 'D4735E3A265E16EEE03F59718B9B5D030', 'anastasia.mak@example.com', 3), -- nasty123
    ('Семенов Сергей Игоревич', 's_serg', '27B2F68D86CEEB196D4A77F9D67F4291', 'semenov.serg@example.com', 3), -- serg456
    ('Иванов Иван Иванович', 'ivaniv', '8D1A8F35F41772C0C9AD52DC8E4EF0D4', 'ivanov.ivan@example.com', 3), -- ivan456
    ('Петров Петр Петрович', 'ppp', 'F87B41EA1948B7E010A90FF43F837171', 'petr.petrov@example.com', 3), -- ppp123
    ('Сидоров Сидор Сидорович', 'sid_sid', '15BF7A427A55E2B798D7AD8B46568F05', 'sidorov.sidor@example.com', 3), -- sidor123
    ('Андреев Андрей Андреевич', 'and_andr', 'A10498067F41F051D89F014C0AE1FC4E', 'andreev.andrey@example.com', 3), -- and456
    ('Николаев Николай Николаевич', 'nik_nik', '2FD4E1C67A2D28FCED849EE1BB76E739', 'nikolay.nik@example.com', 3), -- nik123
    ('Михайлов Михаил Михайлович', 'mih_mih', '5859D9A5F03E7A5BB7D8D9770CF1656A', 'mikhailov.mihail@example.com', 3), -- mih789
    ('Юдин Юрий Юрьевич', 'yur_yud', '85F0A2DB0AD9E7CDCB323B4BD1674D38', 'yudin.yuri@example.com', 3), -- yur456
    ('Романов Роман Романович', 'roma_rom', 'EC9F7EE40C09E94E68335BC3299A194E', 'romanov.roman@example.com', 3), -- roma123
    ('Тимофеев Тимофей Тимофеевич', 'tim_tim', '74B87337454200D4D33F80C4663DC5E5', 'timofeev.tim@example.com', 3), -- tim999
    ('Кузьмин Кузьма Кузьминич', 'kuz_kuz', '5BFA9D279D0C830E8D0CA33D178FC11F', 'kuzmin.kuzma@example.com', 3), -- kuz456
    ('Козлов Козьма Козлович', 'koz_koz', '352B3F3E60E3E8694582F6B1F5BA5400', 'kozlov.kozma@example.com', 3), -- koz789
    ('Лебедев Лебедь Лебедевич', 'leb_leb', '22BFC4044D209586D4D6DCDECC23612A', 'lebedev.leb@example.com', 3), -- leb123
    ('Артемьев Артем Артемьевич', 'art_art', '7F631264FA40E46F861B7A9FBDD2D50E', 'artemev.artem@example.com', 3), -- art555
    ('Владимиров Владимир Владимирович', 'vlad_vlad', 'FA75ECEC5763E793AC0DBBDD3B6D5972', 'vladimirov.vladimir@example.com', 3), -- vlad123
    ('Александров Александр Александрович', 'alex_alex', 'F1FB814C624F05E7E4E9B81C0CE4248F', 'aleksandrov.alex@example.com', 3), -- alex890
    ('Степанов Степан Степанович', 'step_step', '204DA0DB02B47F7262E9A7F3E83D4E82', 'stepanov.stepan@example.com', 3), -- step123
    ('Никитин Никита Никитич', 'nik_nik', 'FE9FC289C3FF0AF142B6D3BEAD98A923', 'nikitin.nikita@example.com', 3), -- nik999
    ('Сергеев Сергей Сергеевич', 'serg_serg', '27B2F68D86CEEB196D4A77F9D67F4291', 'sergeev.sergei@example.com', 3), -- serg123
    ('Максимов Максим Максимович', 'max_max', 'F2E08B8E6364F3F5027A079379F4A7D8', 'maximov.maxim@example.com', 3), -- max456
    ('Павловский Павел Павлович', 'pav_pav', '4FC580C8F7211FE6D9E180BCF46B57C1', 'pavlovsky.pavel@example.com', 3), -- pav789
    ('Дмитриев Дмитрий Дмитриевич', 'dmit_dmit', '2D6A5440B57DA607B94CBE8EDD7EA850', 'dmitriev.dmitry@example.com', 3), -- dmit123
    ('Юрьев Юрий Юрьевич', 'yur_yur', 'B429124DC26427077DB8EA94F7A526E7', 'yurev.yuri@example.com', 3), -- yur789
    ('Иванов Иван Иванович', 'ivan_ivan', '35A7C377DAA8E26B19B0C45C3DEA34CB', 'ivanov.ivan@example.com', 3), -- ivan987
    ('Семенов Семен Семенович', 'sem_sem', '135792468DB48F610EB52E57F0D0A229', 'semenov.semen@example.com', 3), -- sem456
    ('Андреев Андрей Андреевич', 'and_andr', 'FBA0C23456D8592DD43A8F7C5C11D5C2', 'andreev.andrey@example.com', 3); -- and987

COMMIT;
