using System;
class Doctor{
	string fullName;
	string specialty;
	int experience;
	public string TreatPatient(string patientName){
		return $"{fullName}, {specialty}, лечит пациента по имени {patientName}";
	}
	public string PerformMedicalExamination(string patientName){
		return $"{fullName} проводит медицинское обследование для пациента по имени {patientName}";
	}
	public string PrescribeMedication(string patientName, string medication){
		return $"{fullName} назначает {medication} пациенту по имени {patientName}";
	}
	public void SetExperience(int years){
		experience = years;
	}
	public int GetExperience(){
		return experience;
	}
	public Doctor(){

	}
	public Doctor(string fullName, string specialty){
		this.fullName = fullName;
		this.specialty = specialty;
	}
	public Doctor(string fullName, string specialty, int experience){
		this.fullName = fullName;
		this.specialty = specialty;
		this.experience = experience;
	}
}
class Program
{
	static void Main(string[] args)
	{
		Doctor doctor = new Doctor("Dr. Johnson", "Cardiologist", 15);
		System.Console.WriteLine(doctor.TreatPatient("Emily Parker"));
		System.Console.WriteLine(doctor.PerformMedicalExamination("Emily Parker"));
		System.Console.WriteLine(doctor.PrescribeMedication("Antibiotics","James Brown"));
	}
}