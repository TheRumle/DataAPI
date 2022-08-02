using Application.ExamStress.Handlers.Dtos;
using AutoMapper;
using Domain.ExamStress.Entities;
using Domain.ExamStress.Entities.Measurements;

namespace Application.ExamStress.Mappings;

public class StudentToResponseProfile : Profile
{
    public StudentToResponseProfile()
    {
        CreateMap<Student, StudentDataResult>()
            .ForMember(field => field.Id,
                options
                    => options.MapFrom(origin => origin.Id))
            
            .ForMember(field => field.Measurements,
                option
                    => option.MapFrom(delegate(Student student, StudentDataResult result)
                    {
                        List<Measurement> measurements = new(new Measurement[]
                        {
                            student.AccelerometerMeasurement,
                            student.HeartrateMeasurement,
                            student.PhotoplethysmographMeasurement,
                            student.TemperatureMeassurement,
                            student.ElectrodermalActivityMeasurement
                        });
                     
                        return measurements;
                    }));

    }




}
