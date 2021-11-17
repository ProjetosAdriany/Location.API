using System;
using System.Collections.Generic;
using System.Linq;
using Api.Domain.DTOs.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using Xunit;

namespace Api.Service.Test.AutoMapper
{
    public class UserMapper : BaseTestService
    {
        [Fact(DisplayName = "É possível mapear os Modelos")]
        public void E_possivel_mapear_os_modelos()
        {
            var model = new UserModel
            {
                Id = Guid.NewGuid(),
                Name = Faker.Name.FullName(),
                Email = Faker.Internet.Email(),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var listEntity = new List<UserEntity>();
            for (int i = 0; i < 5; i++)
            {
                var item = new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = Faker.Name.FullName(),
                    Email = Faker.Internet.Email(),
                    CreateAt = DateTime.UtcNow,
                    UpdateAt = DateTime.UtcNow
                };
                listEntity.Add(item);
            }

            // Transfere os dados do Model para Entity (ModelToEntity)
            var entity = Mapper.Map<UserEntity>(model);
            Assert.Equal(entity.Id, model.Id);
            Assert.Equal(entity.Name, model.Name);
            Assert.Equal(entity.Email, model.Email);
            Assert.Equal(entity.CreateAt, model.CreateAt);
            Assert.Equal(entity.UpdateAt, model.UpdateAt);


            // Entity => UserDTO
            var userDTO = Mapper.Map<UserDTO>(entity);
            Assert.Equal(userDTO.Id, entity.Id);
            Assert.Equal(userDTO.Name, entity.Name);
            Assert.Equal(userDTO.Email, entity.Email);
            Assert.Equal(userDTO.CreateAt, entity.CreateAt);

            // Lista de Entity para DTO
            var listDTO = Mapper.Map<List<UserDTO>>(listEntity);
            Assert.True(listDTO.Count() == listEntity.Count());
            for (int i = 0; i < listDTO.Count(); i++)
            {
                Assert.Equal(listDTO[i].Id, listEntity[i].Id);
            }

            // Entity => UserCreateResultDTO
            var userDtoCreateResult = Mapper.Map<UserCreateResultDTO>(entity);
            Assert.Equal(userDtoCreateResult.Id, entity.Id);
            Assert.Equal(userDtoCreateResult.Name, entity.Name);
            Assert.Equal(userDtoCreateResult.Email, entity.Email);
            Assert.Equal(userDtoCreateResult.CreateAt, entity.CreateAt);

            // Entity => UserUpdateResultDTO
            var userDtoUpdateResult = Mapper.Map<UserUpdateResultDTO>(entity);
            Assert.Equal(userDtoUpdateResult.Id, entity.Id);
            Assert.Equal(userDtoUpdateResult.Name, entity.Name);
            Assert.Equal(userDtoUpdateResult.Email, entity.Email);
            Assert.Equal(userDtoUpdateResult.UpdateAt, entity.UpdateAt);

            // DTO para Model
            var userModel = Mapper.Map<UserModel>(userDTO);
            Assert.Equal(userModel.Id, userDTO.Id);
            Assert.Equal(userModel.Name, userDTO.Name);
            Assert.Equal(userModel.Email, userDTO.Email);
            Assert.Equal(userModel.CreateAt, userDTO.CreateAt);

            // Model para UserCreateDTO
            var userCreateDTO = Mapper.Map<UserCreateDTO>(userModel);
            Assert.Equal(userCreateDTO.Name, userModel.Name);
            Assert.Equal(userCreateDTO.Email, userModel.Email);

            // Model para UserUpdateDTO
            var userUpdateDTO = Mapper.Map<UserUpdateDTO>(userModel);
            Assert.Equal(userUpdateDTO.Id, userModel.Id);
            Assert.Equal(userUpdateDTO.Name, userModel.Name);
            Assert.Equal(userUpdateDTO.Email, userModel.Email);

        }
    }
}
