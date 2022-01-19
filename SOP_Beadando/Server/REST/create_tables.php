<?php

include_once('./config/database.php');

$database = new Database();
$db = $database->connect();

function set_reset_db($db) {
    drop_table($db);
    create_user_table($db);
    create_jokes_table($db);
    fill_table($db);
}


function drop_table($db) {
    $query = "DROP TABLE IF EXISTS corny_jokes";

    $stmt = $db->prepare($query);
    $stmt->execute();
}

function create_jokes_table($db) {
    $query = "CREATE TABLE IF NOT EXISTS corny_jokes (
        id INT(100) auto_increment primary key,
        content VARCHAR(250) NOT NULL,
        author VARCHAR(250) NOT NULL,
        updated_at DATETIME DEFAULT CURRENT_TIMESTAMP() NOT NULL 
    )";

    $stmt = $db->prepare($query);
    $stmt->execute();
}

function create_user_table($db) {
    $query = "CREATE TABLE IF NOT EXISTS users (
        id INT(100) auto_increment primary key,
        username VARCHAR(250) NOT NULL,
        password VARCHAR(2048) NOT NULL,
        created_at DATETIME DEFAULT CURRENT_TIMESTAMP() NOT NULL,
        modified_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP() NOT NULL
    )";

    $stmt = $db->prepare($query);
    $stmt->execute();
}

function fill_table($db) {
    $db->beginTransaction();
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('Why did the bike fall over? It was two tired.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('What do you call an alligator detective? An investi-gator.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('Why are there gates around cemeteries? Because people are dying to get in.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('What do you call fake spaghetti? An im-pasta.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('Why did the farmer win an award? He was outstanding in his field.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('When do computers overheat? When they need to vent.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('What do you call a factory that sells good products? A satis-factory.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('What do you call a fish without eyes? Fsh.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('What did the tomato say to the other tomato during a race? Ketchup.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('Why wouldn’t the Christmas tree stand up? It had no legs.', current_user)");
    $db->exec("INSERT INTO sop_beadando.corny_jokes (content, author) VALUES ('What falls at the North Pole and never gets hurt? Snow!', current_user)");
    $db->commit();
}