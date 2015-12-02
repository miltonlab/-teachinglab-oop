class Docente:

	def __init__(self, cedula=None, nombres=None):
		self.cedula = cedula
		self.nombres = nombres

	def __repr__(self):
		return self.nombres

if __name__ == "__main__":
	angel = Docente()
	angel.cedula = "11111111";
	angel.nombres = "Angel Bermeo";
	print ("testing...");
	print ("Objetos:  ", angel);

