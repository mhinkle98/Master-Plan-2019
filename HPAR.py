import math

xs = [1, 2, 3, 4, 5]
ys = [8, 3, 2, 2, 8]

def tri(base, height):
    area = (1/2) * base * height
    return area

def rec(base, height):
    area = base * height
    return area

def area(xlist, ylist, wheight):
    area = 0
    min_val = min(ylist)
    max_val = max(ylist)
    for i in range(len(xlist) - 1):
        currentheight = abs(ylist[i] - ylist[i+1])
        xdiff = abs(xlist[i + 1] - xlist[i])
        chunk1 = tri(xdiff, currentheight)
        if i == len(xlist) - 2:
            to_go = 0
        else:
            to_go = max_val - ylist[i]
        chunk2 = rec(xdiff, to_go)
        area += (chunk1 + chunk2)
    return area

def wperim(xlist, ylist, wheight):
    perimeter = 0
    min_val = min(ylist) 
    max_val = max(ylist) 
    for i in range(len(xlist) - 1):
        currentheight = abs(ylist[i] - ylist[i+1])
        xdiff = abs(xlist[i + 1] - xlist[i])
        temp = math.sqrt(currentheight**2 + xdiff**2)
        perimeter += temp
    return perimeter

#print(wperim(xs,ys,7))

def easy(x):
    return str(math.sqrt(x))

print(area([0,1,2,3,4],[4,1,2,0,4],5))