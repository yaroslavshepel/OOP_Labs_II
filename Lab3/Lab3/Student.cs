﻿using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
namespace Lab3;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Course { get; set; }
    public string StudentID { get; set; }
    public enum Gender { 
        Male = 0, 
        Female = 1
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Gender GenderType { get; set; }
    public double AverageGrade { get; set; }
    public string IdentificationCode { get; set; }
    public Student(){}

    public Student(string firstName, string lastName, int course, string studentID, string genderType,
    double averageGrade, string identificationCode)
    {
        FirstName = firstName;
        LastName = lastName;
        Course = course;
        StudentID = studentID;
        GenderType = (Gender)Enum.Parse(typeof(Gender), genderType);
        AverageGrade = averageGrade;
        IdentificationCode = identificationCode;
    }
    
    public static bool ValidateStudentID(string studentId)
    {
        string pattern = @"^ST\d{3}$";
        return Regex.IsMatch(studentId, pattern);
    }
    
    public static bool ValidateIdentificationCode(string identificationCode)
    {
        string pattern = @"^ID\d{3}$";
        return Regex.IsMatch(identificationCode, pattern);
    }
    
    public string DisplayStudent(Student student)
    {
        return $"First name: {student.FirstName} Last name: {student.LastName} Course: {student.Course} Student ID: {student.StudentID} Gender: {student.GenderType} Average grade: {student.AverageGrade} ID code: {student.IdentificationCode}";
    }
}