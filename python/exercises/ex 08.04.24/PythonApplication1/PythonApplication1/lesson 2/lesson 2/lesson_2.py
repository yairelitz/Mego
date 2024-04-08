import random
r=ord('a')
s=""
c=chr(random.randint(97,106))
s=s+c
c=chr(random.randint(97,106))
s=s+c
c=chr(random.randint(97,106))
s=s+c
c=chr(random.randint(97,106))
s=s+c
print(s)


m=[
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0]
    ]






def S1InS2(s1, s2):
    if(len(s1)>len(s2)):
        return False
    for i in range(len(s1)):
        for k in range(len(s2)):
            if(s1[i]==s2[k]):
                break
        if(s1[i]!=s2[k]):
            return False
    return True
print(S1InS2("cea", "casv"))    
print(S1InS2("cxea", "abcdef"))          
print(S1InS2("cjea", "abcdef"))          
print(S1InS2("cea", "cafehb"))    




def S1InS2(s1, s2):
    if(len(s1)>len(s2)):
        return False
    i=0
    while(i<len(s1)):
        k=0
        while(k<len(s2)):
            if(s1[i]==s2[k]):
                break
            k+=1
        if(k==len(s2)):
            return False
        i+=1
    return True
print(S1InS2("cxea", "abcdef"))          
print(S1InS2("cjea", "abcdef"))          
print(S1InS2("ceav", "cae"))           



def CmpString(s1, s2):
    l=len(s1)
    if(len(s1)>len(s2)):
        l=len(s2)
    for i in range(l):
        if(s1[i] != s2[i]):
           return ord(s1[i]) - ord(s2[i])
    return len(s1)-len(s2)
   

print(CmpString("aaa", "bbb"))        
print(CmpString("ccc", "bbb"))        
print(CmpString("aaa", "abb"))        
print(CmpString("axa", "aaaa"))        
print(CmpString("aaaa", "aaa"))        
print(CmpString("aaa", "aaaaaaaa"))        
           






def CmpString(s1, s2):
    l=len(s1)
    if(len(s1)>len(s2)):
        l=len(s2)
    for i in range(l):
        if(ord(s1[i]) < ord(s2[i])):
           return -1
        else:
           if(ord(s1[i]) > ord(s2[i])):
               return 1
    if(len(s1)==len(s2)):
        return 0
    else:
        return len(s1)-len(s2)
   

print(CmpString("aaa", "bbb"))        
print(CmpString("ccc", "bbb"))        
print(CmpString("aaa", "abb"))        
print(CmpString("aaa", "aaaa"))        
print(CmpString("aaaa", "aaa"))        
           

import random
def Show(a):
    for r in range(len(a)):
        for c in range(len(a)):
            print(a[r][c], end=" ")
        print()
           
r=ord('a')
s=""
for i in range(100):
    c=chr(random.randint(97,106))
    s=s+c
print(s)
m=[
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0]
    ]
for i in range(len(s)-1):
    sh=ord(s[i])-97
    a=ord(s[i+1])-97
    m[sh][a]+=1
Show(m)    


import random
r=ord('a')
s=""
c=chr(random.randint(97,106))
s=s+c
c=chr(random.randint(97,106))
s=s+c
c=chr(random.randint(97,106))
s=s+c
c=chr(random.randint(97,106))
s=s+c
print(s)

 
m=[
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0,0,0]
    ]






def S1InS2(s1, s2):
    if(len(s1)>len(s2)):
        return False
    for i in range(len(s1)):
        for k in range(len(s2)):
            if(s1[i]==s2[k]):
                break
        if(s1[i]!=s2[k]):
            return False
    return True
print(S1InS2("cea", "casv"))    
print(S1InS2("cxea", "abcdef"))          
print(S1InS2("cjea", "abcdef"))          
print(S1InS2("cea", "cafehb"))    




def S1InS2(s1, s2):
    if(len(s1)>len(s2)):
        return False
    i=0
    while(i<len(s1)):
        k=0
        while(k<len(s2)):
            if(s1[i]==s2[k]):
                break
            k+=1
        if(k==len(s2)):
            return False
        i+=1
    return True
print(S1InS2("cxea", "abcdef"))          
print(S1InS2("cjea", "abcdef"))          
print(S1InS2("ceav", "cae"))           

def CmpString(s1, s2):
    l=len(s1)
    if(len(s1)>len(s2)):
        l=len(s2)
    for i in range(l):
        if(s1[i] != s2[i]):
           return ord(s1[i]) - ord(s2[i])
    return len(s1)-len(s2)
   

print(CmpString("aaa", "bbb"))        
print(CmpString("ccc", "bbb"))        
print(CmpString("aaa", "abb"))        
print(CmpString("axa", "aaaa"))        
print(CmpString("aaaa", "aaa"))        
print(CmpString("aaa", "aaaaaaaa"))        
           






def CmpString(s1, s2):
    l=len(s1)
    if(len(s1)>len(s2)):
        l=len(s2)
    for i in range(l):
        if(ord(s1[i]) < ord(s2[i])):
           return -1
        else:
           if(ord(s1[i]) > ord(s2[i])):
               return 1
    if(len(s1)==len(s2)):
        return 0
    else:
        return len(s1)-len(s2)
   

print(CmpString("aaa", "bbb"))        
print(CmpString("ccc", "bbb"))        
print(CmpString("aaa", "abb"))        
print(CmpString("aaa", "aaaa"))        
print(CmpString("aaaa", "aaa"))   
