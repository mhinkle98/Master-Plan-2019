from HPAR import HPAR as h
from PyQt5 import QtWidgets, uic

####### Window Setup #######

uipath = "C:/Users/Max Hinkle/Desktop/Dr. Meselhe Work/MasterPlan/Code/HPARpy/HPARpy/test.ui"
app = QtWidgets.QApplication([])
dlg = uic.loadUi(uipath)


    
####### Functions ######

def update():
    xs = []
    ys = []
    xraw = dlg.xs.toPlainText()
    yraw = dlg.ys.toPlainText()
    for item in xraw:
        if item != "," and item != "\n":
            xs.append(int(item))
    for item in yraw:
        if item != "," and item != "\n":
            ys.append(int(item))
    new_area = h.area(xs, ys, 7)
    new_perim = h.wperim(xs, ys, 7)
    dlg.areaLabel.setText("Area: " + str(new_area))
    dlg.wperimLabel.setText("Wet Perimeter: " + str(new_perim))
    xs = []
    ys = []

dlg.DataButton.clicked.connect(update)
dlg.show()
app.exec()
