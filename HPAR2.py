import math


class Trapezoid:

    data_points = {
        0: 10,
        5: 1,
        25: 1,
        30: 10
    }

    def __init__(self, data_point_dict):
        """Enter in a set of graphical points in dictionary format, with x's being
        the keys and y's being the values"""
        self.data_points = data_point_dict
        self.x_values = list(self.data_points.keys())
        self.y_values = list(self.data_points.values())
        self.h_min = min(self.y_values)
        self.left_angle = math.atan((abs(self.y_values[1] - self.y_values[0])) / (abs(self.x_values[1] - self.x_values[0])))
        self.right_angle = math.atan((abs(self.y_values[1] - self.y_values[0])) / (abs(self.x_values[1] - self.x_values[0])))

    def wet_area(self, h_water):
        """All trapezoids should have 4 x/y data pairs"""
        h_water = h_water - self.h_min
        low_length = abs(self.x_values[2] - self.x_values[1])
        left_x_dif = h_water / math.tan(self.left_angle)
        right_x_dif = h_water / math.tan(self.right_angle)
        leftmost_x = self.x_values[1] - left_x_dif
        rightmost_x = self.x_values[2] + right_x_dif
        high_length = abs(rightmost_x - leftmost_x)
        area = h_water * ((low_length + high_length) / 2)
        return area

    def wet_perimeter(self, h_water1):
        h_water = h_water1 - self.h_min
        low_length = abs(self.x_values[2] - self.x_values[1])
        left_x_dif = h_water / math.tan(self.left_angle)  
        right_x_dif = h_water / math.tan(self.right_angle)
        leftmost_x = self.x_values[1] - left_x_dif
        rightmost_x = self.x_values[2] + right_x_dif
        high_length = abs(rightmost_x - leftmost_x)
        left_hyp = math.sqrt(left_x_dif**2 + h_water**2)
        right_hyp = math.sqrt(right_x_dif**2 + h_water**2)
        if h_water1 == self.h_min:
            perimeter = low_length
        else:
            perimeter = high_length + low_length + left_hyp + right_hyp
        return perimeter

    def __repr__(self):
        return "Data points: " + str(self.data_points) + "\nArea of shape: " + \
               str(self.wet_area(max(self.y_values))) + \
               "\nMaximum Perimeter: " + str(self.wet_perimeter(max(self.y_values)))


sampleData = {
    0: 10,
    5: 1,
    25: 1,
    30: 10
}

trap1 = Trapezoid(sampleData)
print(trap1)
print(trap1.wet_area(8))
print(trap1.wet_perimeter(1))


