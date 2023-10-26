using Arch.EntityFrameworkCore.UnitOfWork;
using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CoreLayer.AutoMapper;
using CoreLayer.UnitOfWork.Abstract;
using CoreLayer.UnitOfWork.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Context;
using DataAccesLayer.Concrete.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EstateManagementApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddDbContext<EstateDbContext>(options =>
            //{
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
            //});
            builder.Services.AddDbContext<EstateDbContext>();
            //builder.Services.AddAutoMapper(typeof(Program));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);


            builder.Services.AddScoped<ICategoryService, CategoryManager>();
            builder.Services.AddScoped<ICategoryDal, CategoryDal>();

            builder.Services.AddScoped<IUserService, UserManager>();
            builder.Services.AddScoped<IUserDal, UserDal>();

            builder.Services.AddScoped<ICustomerDal, CustomerDal>();
            builder.Services.AddScoped<ICustomerService, CustomerManager>();

            builder.Services.AddScoped<ICityService, CityManager>();
            builder.Services.AddScoped<ICityDal, CityDal>();

            builder.Services.AddScoped<IDistrictService, DistrictManager>();
            builder.Services.AddScoped<IDistrcitDal, DistrictDal>();

            builder.Services.AddScoped<IEstateService, EstateManager>();
            builder.Services.AddScoped<IEstateDal, EstateDal>();

            builder.Services.AddScoped<IEstateTypeService, EstateTypeManager>();
            builder.Services.AddScoped<IEstateTypeDal, EstateTypeDal>();

            builder.Services.AddScoped<CoreLayer.UnitOfWork.Abstract.IUnitOfWork, CoreLayer.UnitOfWork.Concrete.UnitOfWork<EstateDbContext>>();
           


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}