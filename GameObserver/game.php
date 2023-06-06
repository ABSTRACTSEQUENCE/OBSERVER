<?
include "script.php";
$game = get_game($_GET['game']);

$user = get_user();

$comments = get_comments();

$stmt = sqlsrv_query($connection, 
"SELECT Genres.Name AS 'Genre'
FROM GenreGames, Games, Genres 
WHERE Game_Id = ".$game->Id." 
AND Games.Id = ".$game->Id." 
AND Genres.Id = GenreGames.Genre_Id;");

$rel = array();
while($i=sqlsrv_fetch_array($stmt,SQLSRV_FETCH_ASSOC)){
    array_push($rel, $i);
}

?>
<!DOCTYPE html>
<head>
    <link href="favicon.png" rel="icon" type="image/png">
    <meta charset="utf-8">
    <title><?echo $game->Name?></title> 
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="style.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</head>
<style>
    #container{
        display: flex;
        margin-top: 3%;
        flex-direction: column;
        justify-content: center;
        align-items: center;
    }
    #commentInput{
        border-radius: 20px;
        width: 552%;
    }   
    #comment_section{
        display: flex;
        flex-direction: column;
        align-content: center;
        justify-content: center;
        align-items: center;
    }
    #bt_ok{
        margin-top: 4%;
    }
    #back{
        width: 15%;
        margin-left: 42%;
    }
    #form{
        display: flex;
        flex-flow: column;
        justify-content: center;
        align-items: center;
    }
    #preview{
        display: flex;
        justify-content: center;
        align-items: center;
        margin-bottom: 3%;
    }
    .comments{
        background-color: #212529;
        color: white;
        padding: 1%;
    }
    .comment{
        
    }
    .row{
        justify-content: center;
    }
    .screenshot{
        max-width: 28%;
        margin-right: 5%;
    }
    .screenshot:hover{
        position: absolute;
        max-width: 57%;
        top: 50%;
        left: 16%;

    }
    #screenshot_section{
        margin-top: 2%;
        margin-bottom: 2%;
    }
</style>
<body class="bg-dark text-light">
<div class="col button" id="back"><a href="index.php">Вернуться</a></div>
    <div class="container" id="container">
        <div class="row">
            <div id="preview"><?echo("<img src='/Pictures/Previews/".$game->Name."/".$game->Name.".png'/>")?></div>
            <div class="col"><?echo $game->Name?><br>
                <?echo($game->Description)?>
                </div>
                <div class="row" id="screenshot_section">
                    Скриншоты
                    <p>
                        <?
                        $path = "Pictures/Screenshots/$game->Name";
                        $arr = scandir($path);
                        $arr =array_filter($arr,function($i){return !str_starts_with($i,'.');});
                        for($i = 0; $i < count($arr); $i++ ){
                            echo("<img class = 'screenshot' src = 'Pictures/Screenshots/$game->Name/".$i.".png'>");
                        }
                        ?>
                    </p>
                </div>
        <div class="row">
            <div class="col">Жанры:
            <?
            foreach($rel as $i){
                foreach($i as $j) echo $j.", ";
            }
            ?>
            </div>
        </div>
        </div>
        <div class="row" style="display: flex; flex-flow:column;">
            <div class="container row" id="comment_section">
                <div class="row">Коментарии</div>
            <form method="POST" action="bt_handlers/post comment.php" id="form">
                <textarea name = "text" <?if(!isset($_COOKIE['name'])) echo("disabled placeholder='Войдите на сайт, если хотите прокомментировать' style='background: #f2f2f2;'");?> rows="5" id="commentInput"></textarea>
                <button id='bt_ok' class="button" name="game" value = '<?echo $game->Id?>' type = submit<?if(!isset($_COOKIE['name']))echo(' disabled')?>>Отправить</button>
            </form>

        </div>
            <div class="col comments w-1">
                    <?
                    if($comments){
                        foreach($comments as $i){
                            echo(
                                $i['Username']
                                ." <div class='col comment'>".$i["Text"]//."</div>"
                            );
                            if(isset($_COOKIE['name'])){
                                if($_COOKIE["name"] == "admin") 
                                echo("<button class = 'comment_del button' onclick = 'handler(".$i['CommentId'].",".$game->Id.")'>Удалить</button>");
                            }
                            echo("</div>");
                        }
                    }
                    else echo("<h2>Коментариев нет</h2>");
                    ?>
                    <script>
                        function handler(id, game_id){
                            window.location.replace('bt_handlers/delete_comment.php?id='+id+"&gameId="+game_id)
                        }
                    </script>
                </div>
            </div>
    </div>
</body>