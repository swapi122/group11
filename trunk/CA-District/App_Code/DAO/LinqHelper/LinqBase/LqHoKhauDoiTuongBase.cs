




/*
'===============================================================================
'  LinqHelper.DAO.HoKhauDoiTuongBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqHoKhauDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHoKhauDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqHoKhauDoiTuongEntity obj)
		{
			provider.GetTable<LqHoKhauDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqHoKhauDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqHoKhauDoiTuongEntity tmp = q.First<LqHoKhauDoiTuongEntity>();
			
			tmp.IdHoKhau = _obj.IdHoKhau;
			tmp.IdDoiTuong = _obj.IdDoiTuong;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqHoKhauDoiTuongEntity obj)
		{
			provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHoKhau(Guid IdHoKhau)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.IdHoKhau == IdHoKhau
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.IdDoiTuong == IdDoiTuong
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqHoKhauDoiTuongEntity ob = (LqHoKhauDoiTuongEntity)q.First<LqHoKhauDoiTuongEntity>();
            provider.GetTable<LqHoKhauDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqHoKhauDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqHoKhauDoiTuongEntity>();
		}

		public List<LqHoKhauDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectByIdHoKhau(Guid IdHoKhau)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.IdHoKhau == IdHoKhau
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.IdDoiTuong == IdDoiTuong
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		public List<LqHoKhauDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqHoKhauDoiTuongEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqHoKhauDoiTuongEntity>();
		}
		
		
		

	}
}
