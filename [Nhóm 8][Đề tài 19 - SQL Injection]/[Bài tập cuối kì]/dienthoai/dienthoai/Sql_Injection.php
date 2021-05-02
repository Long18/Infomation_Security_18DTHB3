<?php

	class SQlBl {
	 	public function block3($str){
	 		return str_replace(array("'",'"',"''"), array('&quot;','&quot;'), $str);
	 		
	 	}
	}
?>