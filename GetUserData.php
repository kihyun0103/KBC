<?PHP

$user = $_POST['user'];

$con = mysql_connect("175.223.23.220","root", "111111") or ("Cannot connect!" .mysql_error());
if (!$con)
	die('Could not connect: ' . mysql_error());
	
// "mtg" is the name of your database
mysql_select_db("kbc", $con) or die ("could not load the database" . mysql_error());

$sial = mysql_query("SELECT * FROM account_info WHERE `id` ='".$user."'");


while($row = mysql_fetch_assoc($sial))
{
	$name = $row['name'];
	die($name);
	
}
?>