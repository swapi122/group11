




/*
'===============================================================================
'  LinqHelper.DAO.ThonBase
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
	public class LqThonBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThonBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqThonEntity obj)
		{
			provider.GetTable<LqThonEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqThonEntity _obj)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqThonEntity tmp = q.First<LqThonEntity>();
			
			tmp.TenThon = _obj.TenThon;
			tmp.IdXa = _obj.IdXa;
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
		
		public void Delete(LqThonEntity obj)
		{
			provider.GetTable<LqThonEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenThon(string TenThon)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.TenThon == TenThon
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXa(Guid IdXa)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.IdXa.Value == IdXa
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqThonEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqThonEntity ob = (LqThonEntity)q.First<LqThonEntity>();
            provider.GetTable<LqThonEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqThonEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqThonEntity>();
		}

		public List<LqThonEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByTenThon(string TenThon)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.TenThon == TenThon
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByIdXa(Guid IdXa)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.IdXa.Value == IdXa
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		public List<LqThonEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqThonEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqThonEntity>();
		}
		
		
		

	}
}
