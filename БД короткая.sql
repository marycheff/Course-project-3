CREATE DATABASE IF NOT EXISTS `library` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `library`;

CREATE TABLE `authors` (
  `id` int PRIMARY KEY,
  `name` varchar(50)
);

CREATE TABLE `books` (
  `id` int PRIMARY KEY,
  `title` varchar(50),
  `author_id` int,
  `genre_id` int,
  `description` varchar(50),
  `available` tinyint,
  `cover_image_path` varchar(50)
);

CREATE TABLE `genres` (
  `id` int PRIMARY KEY,
  `name` varchar(50)
);

CREATE TABLE `current_rentals` (
  `id` int PRIMARY KEY,
  `user_id` int,
  `book_id` int,
  `rental_date` datetime,
  `return_date` datetime
);