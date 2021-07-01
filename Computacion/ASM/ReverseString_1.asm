INCLUDE 'EMU8086.INC'             ;include package
.MODEL SMALL
.STACK 100h
.DATA
.CODE
   MAIN PROC
        MOV AX,@DATA
        MOV DS,AX

        XOR BX,BX
        MOV CX,5            ;will take 5 letter
        PRINT "Enter a string: "
    
    INPUT:
        MOV AH,1
        INT 21H
        MOV BL,AL
        PUSH BX
       LOOP  INPUT
     
     PRINTN                 ;new line print
     PRINT "Reverse of this string: "
     MOV CX,5  
     OUTPUT:
        POP BX
        MOV DL,BL
        MOV AH,2
        INT 21H
       LOOP OUTPUT
       
   MAIN ENDP
END MAIN