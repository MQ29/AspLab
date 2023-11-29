﻿using Data;
using Data.Entities;

namespace Lab_3.Models
{
    public class EFContactService : IContactService
    {
        private readonly AppDbContext _context;
        public EFContactService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public int Add(Contact contact)
        {
            Console.WriteLine($"OrganizationId: {contact.OrganizationId}");
            var e = _context.Contacts.Add(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
            int id = e.Entity.ContactId;
            return id;
        }

        public void Delete(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            if(find != null) 
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.ToModel(e)).ToList();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            return _context.Organizations.ToList();
        }

        public Contact? FindById(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            return find != null ? ContactMapper.ToModel(find) : null;
        }

        public PagingList<Contact> FindPage(int page, int size)
        {
            var p = PagingList<Contact>.Create(null, _context.Contacts.Count(), page, size);
            var data = _context.Contacts.OrderBy(o => o.Name)
                              .Skip((p.Number - 1) * p.Size)
                              .Take(p.Size)   
                              .Select(ContactMapper.ToModel)
                              .ToList();
            p.Data = data;
            return p;
        }

        public void Update(Contact contact)
        {
            _context.Contacts.Update(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
        }
    }
}
