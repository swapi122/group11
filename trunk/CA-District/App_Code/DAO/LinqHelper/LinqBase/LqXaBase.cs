




/*
'===============================================================================
'  LinqHelper.DAO.XaBase
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
	public class LqXaBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXaBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqXaEntity obj)
		{
			provider.GetTable<LqXaEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqXaEntity _obj)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqXaEntity tmp = q.First<LqXaEntity>();
			
			tmp.TenXa = _obj.TenXa;
			tmp.IdHuyen = _obj.IdHuyen;
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
		
		public void Delete(LqXaEntity obj)
		{
			provider.GetTable<LqXaEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenXa(string TenXa)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.TenXa == TenXa
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHuyen(Guid IdHuyen)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.IdHuyen.Value == IdHuyen
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqXaEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqXaEntity ob = (LqXaEntity)q.First<LqXaEntity>();
            provider.GetTable<LqXaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqXaEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqXaEntity>();
		}

		public List<LqXaEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByTenXa(string TenXa)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.TenXa == TenXa
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByIdHuyen(Guid IdHuyen)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.IdHuyen.Value == IdHuyen
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		public List<LqXaEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqXaEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqXaEntity>();
		}
		
		
		

	}
}
