<?php

include_once('./config/database.php');
include_once('./objects/Joke.php');
include_once('./objects/User.php');
include_once('./create_tables.php');
include_once ("login.php");
include_once ("create_user.php");
include_once ("validate_token.php");


$database = new Database();
$db = $database->connect();

/*
 * Uncomment the following line to set/reset Database.
 */
//set_reset_db($db);

$joke = new Joke($db);
$user = new User($db);
$request_method = $_SERVER["REQUEST_METHOD"];
$issued_at = time();

switch ($request_method) {
    case 'GET':
        if (!empty($_GET["id"]))
        {
            $id = intval($_GET["id"]);
            $joke->get_joke($id);
        } else
            $joke->get_jokes();
        break;

    case 'POST':
        $data = json_decode(file_get_contents('php://input'), true);
        if (!empty($_GET["comm"]))
        {
            switch (strval($_GET["comm"])){
                case 'login':
                    foreach ($data as $item => $value) {
                        if ($item == "Username") {
                            if ($user->userExists($value)) {
                                $jwt = login();
                                break;
                            }
                        }
                    }
                    break;

                case 'register':
                        create();
                        break;

                default:
                    break;
            }
        }
        else {
            $token = strval($_GET["jwt"]);
            $data = validate($token);
            if (!is_null($data)){
                $items = array();
                foreach ($data as $item => $value)
                    $items[$item] = $value;
                $author = $items["username"];
                $joke->insert_joke($author);
            }
        }
        break;

    case 'PUT':
        $id = intval($_GET["id"]);
        $token = strval($_GET["jwt"]);
        $data = validate($token);

        $query = "SELECT author FROM sop_beadando.corny_jokes WHERE id =' ".$id." 'LIMIT 1";
        $stmt = $db->prepare($query);
        $stmt->execute();
        $author = trim($stmt->fetch(PDO::FETCH_COLUMN));

        $items = array();
        foreach ($data as $item => $value)
            $items[$item] = $value;
        if ($items["username"] == $author) {
            $joke->update_joke($id, $author);
            break;
        } else {
            header("Content-Type: application/json; charset=UTF-8");
            echo json_encode(array(
                "message" => "You don't have permission to do this."
            ));
        }
        break;

    case 'DELETE':
        $id = intval($_GET["id"]);
        $token = strval($_GET["jwt"]);
        $data = validate($token);

        $query = "SELECT author FROM sop_beadando.corny_jokes WHERE id =' ".$id." 'LIMIT 1";
        $stmt = $db->prepare($query);
        $stmt->execute();
        $author = trim($stmt->fetch(PDO::FETCH_COLUMN));

        $items = array();
        foreach ($data as $item => $value)
            $items[$item] = $value;
        if ($items["username"] == $author) {
            $joke->delete_joke($id);
            break;
        } else {
            header("Content-Type: application/json; charset=UTF-8");
            echo json_encode(array(
                "message" => "You don't have permission to do this."
            ));
        }
        break;

    default:
        header("HTTP/1.0 405 Method Not Allowed");
}
