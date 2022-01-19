<?php

Class User
{
    private $conn;

    public $username;
    public $password;

    public function __construct($db)
    {
        $this->conn = $db;
    }

    function create()
    {
        $query = "INSERT INTO sop_beadando.users SET username = :username, password = :password";
        $stmt = $this->conn->prepare($query);

        $this->username = htmlspecialchars(strip_tags($this->username));
        $this->password = htmlspecialchars(strip_tags($this->password));

        $password_hash = password_hash($this->password, PASSWORD_BCRYPT);

        $stmt->bindParam(':username', $this->username);
        $stmt->bindParam(':password', $password_hash);

        if ($stmt->execute())
            return true;
        return false;
    }

    function userExists($username){

        $query = "SELECT id, username, password FROM sop_beadando.users WHERE username = ? LIMIT 0,1";

        $stmt = $this->conn->prepare($query);

        $stmt->bindParam(1, $username);

        $stmt->execute();

        $num = $stmt->rowCount();

        if($num>0){

            $row = $stmt->fetch(PDO::FETCH_ASSOC);

            $this->id = $row['id'];
            $this->username = $row['username'];
            $this->password = $row['password'];

            return true;
        }
        return false;
    }
}