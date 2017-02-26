
#include <stdlib.h>
#include <string.h>
#include <stdio.h>


int main(){
char str[200] = "This is - www.Temple.com - website";
const char s[5] = { ' ','-',',','.' };
char *token;

/* get the first token */
token = strtok(str, s);

/* walk through other tokens */
while (token != NULL)
{
	printf(" %s\n", token);

	token = strtok(NULL, s);
}

return(0);
}