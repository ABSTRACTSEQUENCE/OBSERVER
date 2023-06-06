<!DOCTYPE html>
<head>
    <meta charset="utf-8">
    <link href="favicon.png" rel="icon" type="image/png">
    <title>Регистрация/Вход</title> 
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
    </head>
    <style>
        form{
            width: 55%;
            margin-left: 21%;
        }
        #form{
            display: flex;
            flex-direction: column;
            margin-top: 16%;
            border-radius: 18px;
            padding: 89px
        }
        #reg_input{
            position: relative;
            bottom: 13px;
            left: -96px;
            height: 20px;
        }
        #reg_label{
            position: relative;
            bottom: -7px;
        }
        #bt_reg{
            position: relative;
            bottom: -34px;
        }
        #back{
            margin-top: 3%;
        }
        input{
            background: #212529;
            color: white;
            text-align: center;
        }
    </style>
    <body class="bg-dark text-light">
        <div class="container">
            <div class="row">
                <div class="col" id='back'><a href="index.php">На главную</a></div>
            </div>
        </div>
    <div class="container">
    <form method="post">
            <div class="col" id="form">
                <label for="nickname">Имя</label>
                <input name="nickname">
                <label for="password">Пароль</label>
                <input type="password" name="password">
                <label for="email">Почта</label>
                <input type="email" name="email">
                <label id="reg_label" for="reg">Зарегестрироваться?</label>
                <input name="reg" id="reg_input" value="reg" type="checkbox">
                <button type="submit" class="button" id="bt_reg">OK</button>
            </div>
        <?
       include_once("script.php");
       
        function reg(User $user){
            $connection = sqlsrv_connect("HOME-PC\SQLEXPRESS",array("Database"=>"ObserverDB"));
            if($user->Name == "admin") die("<h1>Аккаунт администратора можно создать только через запрос в БД</h1>");
            $query ="INSERT INTO dbo.Users([Name], [Password], Email) VALUES('"
            .$user->Name."','"
            .$user->Password."','"
            .$user->Email."')";
            if(sqlsrv_query($connection, $query)) {
                echo("Пользователь '".$user->Name."' успешно зарегестрирован");
                $_POST["user"] =$user;
            }
            
            else {
                echo("Во время регистрации произошла ошибка");
                $arr = sqlsrv_errors(); 
                foreach( $arr as $i) {echo"<br>"; var_dump($i);};
                die;
            }
        }
        function login($user){
            setcookie("name",$user->Name);
            if(isset($user->Email)) setcookie("email",$user->Email);
            header("location:index.php");
            die;
        }
        
        if(!empty($_POST["nickname"]) and !empty($_POST["password"])) {
            $user = new User;
            $user->args(
            $_POST["nickname"],
            $_POST["password"],
            $_POST["email"]);
            var_dump($user);
            if($user->Name == "admin" and $user->Password == "admin") login($user);
            $stmt = sqlsrv_query($connection, "SELECT * FROM dbo.Users;");
            while($i = sqlsrv_fetch_object($stmt,"User")){
                
                if(isset($_POST["reg"]))
                if($_POST["reg"] == "reg") {
                    if($i->Name == $user->Name) die("Пользователь с именем ".$i->Name." уже существует");
                }
                if($i->Name == $user->Name){
                        if(strval($i->Password) == $user->Password){
                            if($i->Email == $user->Email) {
                                login($user);
                                break;
                            }    
                        }
                        die("<h1>Ошибка: неправильно введены данные</h1>");    
                    }      
            }
            if(isset($_POST["reg"]))
            if($_POST["reg"] == "reg") {
                reg($user);die;
            }
            echo("<h4>Пользователь с именем '".$user->Name."' не найден в базе данных</h4>");
        }
        else die("Необходимо заполнить все поля");
        ?>
    </form>
    </body>