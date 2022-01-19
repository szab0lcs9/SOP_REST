<?php

Class Database {
    private $host = 'localhost';
    private $db_name = 'sop_beadando';
    private $username = 'root';
    private $password = '';
    private $dsn = null;
    private $conn = null;

    public function connect()
    {
        try {
            $this->dsn = "mysql:host=$this->host;dbname=$this->db_name";
            $this->conn = new PDO($this->dsn, $this->username, $this->password);
            $this->conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        } catch (PDOException $exception) {
            echo 'Failed to connect to database.';
            echo 'Error message: ' . $exception->getMessage();
        }

        return $this->conn;
    }
}