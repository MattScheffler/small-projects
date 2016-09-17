//A base telescope class and derived classes for several different types.
//Optical telescopes only for now.
//Coordinates used are RA and DEC and assumed to be in degrees for simplicity.
#pragma once

class Telescope
{
protected:
	std::string Name;
	double Resolution;
	//primary mirror (or lens) size
	float Primary;
	float Focal;
	double RA;
	double DEC;
public:
	Telescope(std::string name = "", const double resolution = 0, const float primary = 0, const float focal = 0) : 
		Name{ name }, Resolution{ resolution }, Primary{ primary }, Focal{ focal } {}

	std::string getName() { return Name; }
	double getResolution() { return Resolution; }
	float getPrimary() { return Primary; }
	double getRA() { return RA; }
	double getDEC() { return DEC; }
	void getPosition() { std::cout << "RA: " << RA << ", DEC: " << DEC << std::endl; }

	virtual void move(double ra, double dec) = 0;
	virtual void takeImage() = 0;
};

class Type1 : public Telescope
{
private:
	//this type uses a seconday mirror
	float Secondary;
public:
	Type1(std::string name, double resolution, float primary, float focal, float secondary) : Telescope(name, resolution, primary, focal), Secondary{ secondary } {}

	float getSecondary() { return Secondary; }

	void move(double ra, double dec)
	{
		//actions to move telecsope

		RA = ra;
		DEC = dec;

		std::cout << Name << " postion: " << RA << ", " << DEC << std::endl;
	}

	void takeImage()
	{
		//image taking steps
		//storing image steps

		std::cout << Name << " has taken an image." << std::endl;
	}
};

class Type2 : public Telescope
{
public:
	Type2(std::string name, double resolution, float primary, float focal) : Telescope(name, resolution, primary, focal) {}

	void move(double ra, double dec)
	{
		//actions to move telecsope

		RA = ra;
		DEC = dec;

		std::cout << Name << " postion: " << RA << ", " << DEC << std::endl;
	}

	void takeImage()
	{
		//image taking steps
		//storing image steps

		std::cout << Name << " has taken an image." << std::endl;
	}
};