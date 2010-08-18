




/*
'===============================================================================
'  LinqHelper.DAO.ChucVuBase
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
	public class LqChucVuBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucVuBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqChucVuEntity obj)
		{
			provider.GetTable<LqChucVuEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqChucVuEntity _obj)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqChucVuEntity tmp = q.First<LqChucVuEntity>();
			
			tmp.TenChucVu = _obj.TenChucVu;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqChucVuEntity obj)
		{
			provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenChucVu(string TenChucVu)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.TenChucVu == TenChucVu
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqChucVuEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqChucVuEntity ob = (LqChucVuEntity)q.First<LqChucVuEntity>();
            provider.GetTable<LqChucVuEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqChucVuEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqChucVuEntity>();
		}

		public List<LqChucVuEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByTenChucVu(string TenChucVu)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.TenChucVu == TenChucVu
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		public List<LqChucVuEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqChucVuEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqChucVuEntity>();
		}
		
		
		

	}
}
